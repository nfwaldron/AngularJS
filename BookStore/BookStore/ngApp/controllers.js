(function () {
    var app = angular.module('BookApp');
    app.controller('BooksController', function ($resource, $modal, booksControllerUrl, demoService) {
        var self = this;
       
        function lolz() {
            demoService.haha();
        }
        // If a function is being used to represent a class put it in uppercase.
        // the $resource will go off to the books controller, and go to the get method,
        // and 
        var Book = $resource('/api/books/:id');

        self.books = Book.query();

        self.remove = function (book) {
            book.$remove({ id: book.id }, function () {
                self.books = self.books.filter(function (item) {
                    return item.id != book.id;
                })
            });
        };

        self.createBook = function () {
            var book = new Book(self.book);
            // After book has been added, the function will update the new book that was added to the view
            book.$save(function (newBook) {
                self.books.push(newBook);

                // The book that you're editing...
                self.book = null;
            });
        };

        self.showEditModal = function (id) {
            $modal.open({
                templateUrl: '/ngViews/editModal.html',
                controller: 'ModalController',
                controllerAs: 'modal',
                resolve: {
                    id: function () {
                        return id;
                    }
                }
            }).result.then(function () {
                self.books = Book.query();
            });
        }
        lolz();
    });

    app.controller('ModalController', function (id, $modalInstance, $resource, booksControllerUrl) {
        var self = this;
        var Book = $resource('/api/books/:id');
        self.book = Book.get({ id: id });

        self.editBook = function () {
            self.book.$save(function (){
            $modalInstance.close();
        });
        };

        });
})();