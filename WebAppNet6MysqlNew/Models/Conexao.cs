using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace WebAppNet6MysqlNew.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Conexao : DbContext
    {
        public DbSet<ServiceStats> ServiceStats { get; set; }
        public Conexao()
        : base("server=127.0.0.1;database=nome_do_banco;user=Seu_usuário_do_banco;password=sua_senha_do_banco;default command timeout=20;persistsecurityinfo=True;SslMode=none")
        {

        }
    }
}
