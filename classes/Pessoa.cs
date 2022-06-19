using er2.interfaces;

namespace er2.classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        
        public float Rendimento { get; set; }
        
        public string? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
    }
}