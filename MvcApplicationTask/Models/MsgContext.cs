using System.Data.Entity;

namespace MvcApplicationTask.Models
{
    public class MsgContext : DbContext
    {
        // Vous pouvez ajouter du code personnalisé à ce fichier. Les modifications ne seront pas remplacées.
        // 
        // Si vous voulez qu’Entity Framework abandonne et régénère la base de données
        // automatiquement à chaque fois que vous modifiez le schéma du modèle, ajoutez le code
        // suivant à la méthode Application_Start dans le fichier Global.asax.
        // Remarque : cette opération supprime et recrée la base de données à chaque modification du modèle.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MvcApplicationTask.Models.MsgContext>());

        public MsgContext() : base("name=MsgContext")
        {
        }

        public DbSet<MsgModels> MsgModels { get; set; }
    }
}
