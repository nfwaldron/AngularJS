(function () {
    var app=angular.module('BootstrapApp');
    app.controller('PageController', function ($modal) {
        this.showModal = function (id) {
            $modal.open({
                templateUrl: '/ngViews/ModalDetails.html',
                controller: 'ModalDetailsController as modal',
                // To pass id of a model to the modal
                resolve: {
                    id: function () {
                        return id;
                    }
                }
            });
        };

    });
    app.controller('ModalDetailsController', function(id, $modalInstance) {
        this.message = 'My id is ' + id;
        this.ok = function () {
            $modalInstance.close();
        };
    });


})();