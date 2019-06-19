﻿/// <reference path="/Assets/admin/libs/angular/angular.js" />
(function () {
    angular.module('pecoshop',
        ['pecoshop.products',
        'pecoshop.common',
        'pecoshop.product_categories'
        ]).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: '/admin',
            templateUrl: '/app/components/home/homeView.html',
            controller: 'homeController'
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();