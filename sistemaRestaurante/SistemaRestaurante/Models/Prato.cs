namespace SistemaRestaurante.Models
{
    /// <summary>
    /// Modelo do prato.
    /// </summary>
    public class Prato
    {
        public int PratoID { get; set; }
        public int RestauranteID { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public virtual Restaurante Restaurante { get; set; }
    }
}