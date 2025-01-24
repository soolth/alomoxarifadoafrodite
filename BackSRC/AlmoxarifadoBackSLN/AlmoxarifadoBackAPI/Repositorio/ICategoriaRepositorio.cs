using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface ICategoriaRepositorio
    {
        void Add(Categoria categoria);

        List<Categoria> GetAll();
    }
}
