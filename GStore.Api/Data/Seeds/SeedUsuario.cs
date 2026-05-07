using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GStore.Api.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
           #region Perfil
           List<IdentityRole> perfis = [
                new() {
                    Id = "66ef1245-d453-4178-aaf5-e9f58103edf6",
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },               
                new() {
                    Id = "c820d34d-ad65-4544-ad89-fd69c821c118",
                    Name = "Cliente",
                    NormalizedName = "CLIENTE"
                }               
           ];
           builder.Entity<IdentityRole>().HasData(perfis);
           #endregion

           #region Usuários
           #endregion

           #region Usuário Perfil
           #endregion
    }
}
