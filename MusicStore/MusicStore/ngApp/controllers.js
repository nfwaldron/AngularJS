(function () {
    var app = angular.module('myApp');

    // Album service is being passed through dependency injection
    app.controller('AlbumsController', function (albumService, $modal) {
        var self = this;
        self.albums = [];

        // A property of our view model that is equal to anonymous function that
        // returns a list of 
        self.getAlbums = function () {
            // call to album service and get the listAll method
            self.albums = albumService.listAll();
        }

        //SHOW CREATE MODAL
        self.showCreateModal = function () {
            $modal.open({
                templateUrl: '/ngViews/createModal.html',
                controller: 'CreateAlbumModal',
                controllerAs: 'modal'
            });
        }


        // Method called to update the list of albums
        self.getAlbums();
    });

    app.controller('CreateAlbumModal', function ($modalInstance, albumService) {
        var self = this;

        self.save = function () {
            albumService.save(self.album);
            $modalInstance.close();
        };

    })




})();