using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace agape_rfid_mobile
{
    class NFCStandarForMifare
    {

        private const byte SHORT_RECORD_HEADER = 0xD1;
        private const byte NDEF_MESSAGE_TLV = 0x03;

        private const int INDEX_T = 0;
        private const int INDEX_L = 1;
        private const byte FLAG_L_3_BYTES = 0xFF;
        private const int MAX_L = 65534;//FFFEs

        private const byte AID_1 = 0x03;
        private const byte AID_2 = 0xE1;

        public static byte CalcMifCrc(byte[] array_in)
        {
            byte crc, i, j;

            crc = 0xE3;

            for (j = 0; j < array_in.Length; j++)
            {
                crc = (byte)(crc ^ array_in[j]);
                for (i = 0; i < 8; i++)
                {
                    if ((crc & 0x80) > 0)
                        crc = (byte)((crc << 1) ^ 0x1D);
                    else
                        crc = (byte)(crc << 1);
                }
            }
            return crc;
        }

        public static String[] encodeMAD(string KeyB, int dataLength)
        {
            int nb_sectors = dataLength/3;
            if(dataLength%3>0)
                dataLength++;

            byte[] mad_array = new byte[32];
            for (int i = 0; i < 32; i++)
                mad_array[i] = 0;
            int offset_mad = 2;
            int offset_crc = 0;
            byte[] crc_array = new byte[30];
            for (int i = 0; i < 30; i++)
                crc_array[i] = 0;

            for (int i = 0; i < nb_sectors; i++)
            {
                crc_array[offset_crc] = AID_1;
                mad_array[offset_mad] = AID_1;
                offset_crc++;
                offset_mad++;
                crc_array[offset_crc] = AID_2;
                mad_array[offset_mad] = AID_2;
                offset_crc++;
                offset_mad++;
            }

            mad_array[0] = CalcMifCrc(crc_array);

            string tmp = createStrFromByteArray(mad_array);

            string[] madData = new string[3];
            madData[0] = tmp.Substring(0, 32);
            madData[1] = tmp.Substring(32, 32);
            madData[2] = "A0A1A2A3A4A5" + "787788C1" + KeyB;

            return madData;

        }

        public static String encodeURI(byte uriPrefix,String uriContent)
        {
            byte[] UPayload_result = encode_URI_Payload(uriPrefix,createByteArrayFromAsciiStr(uriContent));
            byte[] UNDEF_result = encode_URI_NDEF(SHORT_RECORD_HEADER, UPayload_result);
            byte[] Data = encodeTLV(NDEF_MESSAGE_TLV, UNDEF_result);
            return createStrFromByteArray(Data);
        }

        private static byte[] encode_URI_Payload(byte URI_identifier_code, byte[] URI)
        {

            byte[] payloadEncoded = new byte[URI.Length + 1];
            payloadEncoded[0] = URI_identifier_code;
            if (URI.Length > 0)
            {
                for (int cpt = 0; cpt < URI.Length; cpt++)
                    payloadEncoded[cpt + 1] = URI[cpt];
            }
            return payloadEncoded;
        }

        private static byte[] createByteArrayFromAsciiStr(string StrIn)
        {
            byte[] array = new byte[StrIn.Length];

            for (int cpt = 0; cpt < StrIn.Length; cpt++)
                array[cpt] = (byte)System.Convert.ToChar(StrIn[cpt]);

            return array;

        }

        private static string createStrFromByteArray(byte[] byteArray)
        {
            string Str = "";
            for (int cpt = 0; cpt < byteArray.Length; cpt++)
                Str += String.Format("{0:X2}", byteArray[cpt]);
            return Str;
        }

        private static byte[] encode_URI_NDEF(byte header, byte[] payload)
        {
            byte[] NDEFEncoded = new byte[256];

            if (payload.Length < 256)
            {
                // Short record
                NDEFEncoded = new byte[payload.Length + 4];
                NDEFEncoded[0] = header;
                NDEFEncoded[1] = 0x01;
                NDEFEncoded[2] = (byte)(payload.Length);
                NDEFEncoded[3] = (byte)'U';
                for (int cpt = 0; cpt < payload.Length; cpt++)
                    NDEFEncoded[cpt + 4] = payload[cpt];
            }

            return NDEFEncoded;
        }

        private static byte[] encodeTLV(byte type, byte[] values)
        {

            byte[] TLV_array;
            int start_v = INDEX_L + 1;

            if (values.Length < FLAG_L_3_BYTES)
            {
                TLV_array = new byte[values.Length + 2];
                TLV_array[INDEX_T] = type;
                TLV_array[INDEX_L] = (byte)values.Length;
            }
            else
            {
                int V_size;
                start_v += 2;
                V_size = values.Length;
                if (values.Length > MAX_L)
                    V_size = MAX_L;
                TLV_array = new byte[V_size + 4];
                TLV_array[INDEX_T] = type;
                TLV_array[INDEX_L] = FLAG_L_3_BYTES;
                TLV_array[INDEX_L + 1] = (byte)(V_size >> 8);
                TLV_array[INDEX_L + 2] = (byte)V_size;
            }

            for (int cpt = start_v; cpt < TLV_array.Length; cpt++)
                TLV_array[cpt] = values[cpt - start_v];

            return TLV_array;
        }
    }

    public class URIPrefix
    {
        public const byte EMPTY = 0x0;
        public const byte HTTP_WWW = 0x1;
        public const byte HTTPS_WWW = 0x02;
        public const byte HTTP = 0x03;
        public const byte HTTPS = 0x04;
        public const byte TEL = 0x05;
        public const byte MAILTO = 0x06;
        public const byte FTP = 0x0D;
        public const byte FTPS = 0x09;
        public const byte SFTP = 0x0A;
        public const byte SMB = 0x0B;
        public const byte NFS = 0x0C;
        public const byte TELNET = 0x10;
        public const byte FILE = 0x1D;
        public const byte URN_NFC = 0x23;
    }
}