using System;
namespace MusicStore.Services
{
     public interface IAlbumServices
    {
        void Create(MusicStore.Models.Album album);
        void Edit(MusicStore.Models.Album album);
        MusicStore.Models.Album Find(int id);
        System.Collections.Generic.IList<MusicStore.Models.Album> List();
    }
}
