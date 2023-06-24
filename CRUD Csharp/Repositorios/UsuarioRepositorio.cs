using CRUD_Csharp.Data;
using CRUD_Csharp.Models;
using CRUD_Csharp.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Csharp.Repositorios
{
    

    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDB _dbContext;

        public UsuarioRepositorio(SistemaTarefasDB sistemaTarefasDB)
        {
            _dbContext = sistemaTarefasDB;
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return  await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<UsuarioModel>> BuscatarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }


    }
}
