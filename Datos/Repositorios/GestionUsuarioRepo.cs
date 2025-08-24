    using System;
    using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Datos.Context;
    using Entidades;
    using Microsoft.EntityFrameworkCore;
    namespace Datos.Repositorios;

public class GestionUsuarioRepo
{

    public AppDbContext _db;
    public GestionUsuarioRepo(AppDbContext db)
    {
        _db = db;

    }

    public async Task<List<Usuario>> MostrarUsua()
    {
        return await _db.Usuarios
                        .Select(u => new { u.id, NombreCompleto = u.Nombre + " " + u.Apellido, u.Rut, u.Activo })
                        .TolistAsync();
    }

    public async Task<List<Usuario>> MostrarActivo()
    {

        return await _db.Usuarios
                        .Where(u => u.Activo == 1)
                        .Select(u => new { u.id, NombreCompleto = u.Nombre + " " + u.Apellido, u.Rut, u.Activo })
                        .TolistAsync();
    }

    public async Task<List<Usuario>> MostrarDesactivados()
    {
        return await _db.Usuarios
                        .Where(u => u.Activo == 0)
                        .Select(u => new { u.id, NombreCompleto = u.Nombre + " " + u.Apellido, u.Rut, u.Activo })
                        .TolistAsync();
    }


    public async Task<bool> ModificarUsua(int id, string Nombre, string Apellido, int Rut, long Telefono, string Correo, int Activo)
    {
        var BuscarUsuario = await _db.Usuarios.FindAsync(id);

        if (BuscarUsuario != null)
        {
            BuscarUsuario.Nombre = Nombre;
            BuscarUsuario.Apellido = Apellido;
            BuscarUsuario.Rut = Rut;
            BuscarUsuario.Correo = Correo;
            BuscarUsuario.Activo = Activo;

            await _db.SaveChangesAsync();
            return true;

        }
        else
        {
            return false;
        }
    }

    public async Task<bool> Act_Desa_Usua(int id,int activo)
    {
        var usuario = _db.Usuarios.FindAsync(id);

        if (usuario == null) { return false; }

        if (usuario.Activo == activo)
        {
            usuario.Activo = 1;
        }
        else
        {
            usuario.Activo = 0;
        }

        return await _db.SaveChangesAsync();
    }

    public async Task<bool> CrearUsuario(Usuario usuario)
    {
        _db.Usuarios.Add(usuario);
        _db.SaveChangesAsync();
        return true;

    }        
    }