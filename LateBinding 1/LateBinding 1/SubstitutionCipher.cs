using System;

namespace LateBinding_1
{
    class SubstitutionCipher : Cipher
    {
        private String _strRule;
        public SubstitutionCipher()
        {
            _strRule = "jfkgotmyvhspcandxlrwebquiz";
        }

        public SubstitutionCipher(String strRule)
        {
            if (strRule.Length == 26)
                _strRule = strRule;
            else
                _strRule = "jfkgotmyvhspcandxlrwebquiz";
        }

        public override string Encrypt(string str)
        {
            String strEnc = "";
            char[] Datas = str.ToCharArray();

            foreach (char data in Datas)
            {
                char temp = data;
                if (Char.IsLower(data))
                    temp = _strRule[(byte)data - (byte)'a'];
                strEnc += temp;
            }
            return strEnc;
        }

        public override string Decrypt(string str)
        {
            String strDec = "";
            char[] Datas = str.ToCharArray();

            foreach (char data in Datas)
            {
                char temp = data;
                if (Char.IsLower(data))
                    temp = (char)(_strRule.IndexOf(data) + 'a');
                strDec += temp;
            }
            return strDec;
        }
    }
}