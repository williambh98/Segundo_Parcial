using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.BLL
{
    public class MetasBLL
    {
        static RepositorioBase<Metas> repositorio;

        public static bool Guardar(Vendedor vendedor)
        {
            repositorio = new RepositorioBase<Metas>();
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                foreach (var item in vendedor.Metas)
                {
                    var cuota = contexto.Metas.Find(item.MetasID);
                    cuota.Cuota -= item.Cuota;
                }
                if (contexto.Vendedorp.Add(vendedor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            var Anterior = MetasBLL.Buscar(vendedor.VendedorID);
            Contexto contexto = new Contexto();
            try
            {
                vendedor.Metas.Count();
                foreach (var item in Anterior.Metas)
                {
                    if (!vendedor.Metas.Exists(d => d.Venid== item.Venid))
                        contexto.Entry(item).State = EntityState.Deleted;
                }
                foreach (var item in vendedor.Metas)
                {
                    var estado = (item.Venid == 0) ? EntityState.Added : EntityState.Modified;
                    contexto.Entry(item).State = estado;
                }
                contexto.Entry(vendedor).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Vendedorp.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Vendedor Buscar(int id)
        {
            var vendedor = new Vendedor();
            Contexto contexto = new Contexto();
            try
            {
                vendedor = contexto.Vendedorp.Find(id);
                if (vendedor == null)
                    return vendedor;
                vendedor.Metas.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return vendedor;
        }

        public static List<Vendedor> GetList(Expression<Func<Vendedor, bool>> expression)
        {
            List<Vendedor> Lista = new List<Vendedor>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.Vendedorp.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}

