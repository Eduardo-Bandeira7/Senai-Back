using er2.interfaces;

namespace er2.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string? Cpf { get; set; }

        public DateTime DataNasc { get; set; }




        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - DataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            return false;

        }

        public bool ValidarDataNasc(String DataNasc)
        {
            DateTime DataConvertida;

            if (DateTime.TryParse(DataNasc, out DataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - DataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}