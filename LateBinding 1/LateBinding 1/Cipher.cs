using System;

namespace LateBinding_1
{
    class Cipher
    {
        private int _offset;
        public Cipher()
        {
            _offset = 1;
        }

        public Cipher(int offset)
        {
            if (offset >= 1)
                this._offset = offset;
            else
                this._offset = 1;
        }

        public virtual String Encrypt(String str)
        {
            char[] Datas = str.ToCharArray();
            String strEnc = "";

            foreach (char data in Datas)
            {
                char temp;
                temp = (char)(data + _offset);
                strEnc += temp;
            }
            return strEnc;
        }

        public virtual String Decrypt(String str)
        {
            char[] Datas = str.ToCharArray();
            String strDec = "";

            foreach (char data in Datas)
            {
                char temp;
                temp = (char)(data - _offset);
                strDec += temp;
            }
            return strDec;
        }
    }
}
