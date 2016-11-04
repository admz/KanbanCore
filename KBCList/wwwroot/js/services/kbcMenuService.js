(function (angular) {
  'use strict';

  angular
    .module('KBCList')
    .factory('kbcMenuService', kbcMenuService);

  kbcMenuService.$inject = ['$http'];

  function kbcMenuService($http) {
    var service = {
      getKBCMenu: getKBCMenu
    };

    return service;

    function getKBCMenu() {
      return $http.get("/api/KbcMenu/");
    };
  };
})(window.angular);