using CoderCamps;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Services
{
    public class AlbumServices : MusicStore.Services.IAlbumServices
    {
        private IGenericRepository _repo;

        public AlbumServices(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<Album> List()
        {
            return _repo.Query<Album>().ToList();
        }

        public Album Find(int id)
        {
            return _repo.Find<Album>(id);
        }

        public void Create (Album album)
        {
            _repo.Add<Album>(album);
            _repo.SaveChanges();
        }

        public void Edit (Album album)
        {
            var original = this.Find(album.Id);
            original.Title = album.Title;
            original.Artist = album.Artist;
            original.Genre = album.Genre;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<Album>(id);
            _repo.SaveChanges();
        }

    }
}