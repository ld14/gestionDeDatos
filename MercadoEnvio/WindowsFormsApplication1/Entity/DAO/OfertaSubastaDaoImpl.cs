using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Entity.DAO;


namespace WindowsFormsApplication1
{
    class OfertaSubastaDaoImpl : OfertaSuabastaDao
    {

        public void Add(Ofertasubasta ofertaSuabasta)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Ofertasubasta newEntityRef = manager.Session.Merge(ofertaSuabasta);
                    manager.Session.Save(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Update(Ofertasubasta ofertaSuabasta)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Ofertasubasta newEntityRef = manager.Session.Merge(ofertaSuabasta);
                    manager.Session.Update(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public void Remove(Ofertasubasta ofertaSuabasta)
        {
            using (NHibernateManager manager = new NHibernateManager()) {
                using (ITransaction transaction = manager.Session.BeginTransaction()) {
                    Ofertasubasta newEntityRef = manager.Session.Merge(ofertaSuabasta);
                    manager.Session.Delete(newEntityRef);
                    transaction.Commit();
                }
            }
        }

        public IList<Ofertasubasta> GetByPublicacion(int id)
        {
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.QueryOver<Ofertasubasta>().Where(x => x.PublicacionSubasta.idPublicacion == id).List();
            }
        }


    }

    
}
