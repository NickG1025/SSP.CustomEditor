epiJQuery(function () {
    epiJQuery("head").append("<link rel='stylesheet' href='/SSP.CustomEditor/css/epi-lightSkin-mod.css' type='text/css' />");

    // firefox 11 fix
    // http://world.episerver.com/Modules/Forum/Pages/Thread.aspx?id=57591&epslanguage=en
    epiJQuery('.mceEditor .mceIframeContainer iframe').each(function (i) {
        epiJQuery(this).height(epiJQuery(this).height() + 1);
    });
});
