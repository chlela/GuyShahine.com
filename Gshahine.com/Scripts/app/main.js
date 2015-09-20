if (navigator.userAgent.match(/IEMobile\/10\.0/)) {
    var msViewportStyle = document.createElement('style')
    msViewportStyle.appendChild(
      document.createTextNode(
        '@-ms-viewport{width:auto!important}'
      )
    )
    document.querySelector('head').appendChild(msViewportStyle)
}

// Crazy egg script
setTimeout(function () {
    var a = document.createElement("script");
    var b = document.getElementsByTagName("script")[0];
    a.src = document.location.protocol + "//script.crazyegg.com/pages/scripts/0015/6648.js?" + Math.floor(new Date().getTime() / 3600000);
    a.async = true; a.type = "text/javascript"; b.parentNode.insertBefore(a, b)
}, 1);

// Google Analytics script
var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-15230844-1']);
_gaq.push(['_trackPageview']);

(function () {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
})();