var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('BoilerPlate_Project');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);