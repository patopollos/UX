jQuery(document).ready(function (a) {
  var i = a("#faqs .faq");
  if ("" != window.location.hash) {
    var e = window.location.hash.split("#");
    if (i.hasClass(e[1])) {
      a(".grid-filter li").removeClass("activeFilter"),
        a('[data-filter=".' + e[1] + '"]')
          .parent("li")
          .addClass("activeFilter");
      var l = "." + e[1];
      i.css("display", "none"), "all" != l ? a(l).fadeIn(500) : i.fadeIn(500);
    }
  }
  a(".grid-filter a").on("click", function () {
    a(".grid-filter li").removeClass("activeFilter"),
      a(this).parent("li").addClass("activeFilter");
    var e = a(this).attr("data-filter");
    return (
      i.css("display", "none"),
      "all" != e ? a(e).fadeIn(500) : i.fadeIn(500),
      !1
    );
  });
});
