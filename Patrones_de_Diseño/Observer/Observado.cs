namespace Patrones_de_Diseño.Observer
{
    public interface IObservado
    {
        void AgregarObservador(IObservador o);
        void QuitarObservador(IObservador o);
        void Notificar();
    }
}
