using System.Text.RegularExpressions;
using er2.interfaces;

namespace er2.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f; // mesma coisa que rendimento / 100 * 2;
            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f; // rendimento / 100 * 5;
            }
            else if (rendimento <= 10000)
            {
                return rendimento * .07f; // rendimento / 100 * 7;
            }
            else
            {
                return rendimento * .09f; // rendimento / 100 * 9;
            }
        }

        //xx.xxx.xxx/0001-xx...............xxxxxxxx0001xx
        public bool ValidarCnpj(string cnpj)
        {
            // if Regex.isMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj = cnpj.Substring(11, 4);
                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }

                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8, 4);
                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}