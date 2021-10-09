namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorio
    {
        IEnumerable<Formador> GetAllFormadores();
        Formador AddFormador(Formador formador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador);    
        Formador GetFormador(int idFormador);

    }
}