epiJQuery(function () {
    epiJQuery("head").append("<link rel='stylesheet' href='/SSP.CustomEditor/css/epi-lightSkin-mod.css' type='text/css' />");
});

epiJQuery(window).load(function () {
    // firefox 11 fix
    // http://world.episerver.com/Modules/Forum/Pages/Thread.aspx?id=57591&epslanguage=en
    epiJQuery('.mceEditor').each(function (i) {
        epiJQuery(this).height(epiJQuery(this).height() + 1);
    });
});