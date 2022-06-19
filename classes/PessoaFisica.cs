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
            throw new NotImplementedException();
        }
    }
}