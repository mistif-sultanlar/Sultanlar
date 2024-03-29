
/*==================================================================
[ Validate ]*/
/*var input = $('.validate-input .input100');

$('.validate-form').on('submit', function () {
    var check = true;

    for (var i = 0; i < input.length; i++) {
        if (validate(input[i]) == false) {
            showValidate(input[i]);
            check = false;
        }
    }

    return check;
});*/

var apiurl = "http://localhost:50544/internet/";
//http://localhost:50544/internet/
//http://95.0.47.130/SulAPI/internet/
//https://www.ittihadteknoloji.com.tr/internet/


var aramadelay = 1000;
var surum = '1.4';



$(document).ready(function () {
    $("#dtTable input[type=text]").keyup(function () {
        $(this).val($(this).val().toLocaleUpperCase());
    });

    $('#selectYil').empty();
    $("#selectYil").append($("<option />").val("2022").text("2022"));
    $("#selectYil").append($("<option />").val("2021").text("2021"));
    $("#selectYil").append($("<option />").val("2020").text("2020"));
    $("#selectYil").append($("<option />").val("2019").text("2019"));
    $("#selectYil").append($("<option />").val("2018").text("2018"));
    $("#selectYil").append($("<option />").val("2017").text("2017"));
    $("#selectYil").append($("<option />").val("2016").text("2016"));
    $("#selectYil").append($("<option />").val("2015").text("2015"));
    $("#selectYil").append($("<option />").val("2014").text("2014"));

    if (typeof Android !== "undefined") {
        $("input").focus(function () {
            if ($(this).hasClass("tarihpicker")) {
                Android.HideKeyboard();
            }
        });
    }
});

function validate(input) {
    if ($(input).attr('type') === 'email' || $(input).attr('name') === 'email') {
        if ($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) === null) {
            return false;
        }
    }
    else if ($(input).hasClass("clGerekli")) {
        if ($(input).val().trim() === '') {
            return false;
        }
    }
    else if ($(input).attr('name') === 'inputSifre2') {
        if ($(input).val() !== $('#inputSifre').val()) {
            return false;
        }
    }
}

function showValidate(input) {
    var thisAlert = $(input).parent();

    $(thisAlert).addClass('alert-validate');
}

function hideValidate(input) {
    var thisAlert = $(input).parent();
    
    $(thisAlert).removeClass('alert-validate');
}

function createCookie(name, value, days) {
    var expires = "";
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + days * 24 * 60 * 60 * 1000); //(days * 24 * 60 * 60 * 1000)
        expires = "; expires=" + date.toUTCString();
    }
    document.cookie = name + "=" + value + expires + "; path=/";
}

function readCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}

function eraseCookie(name) {
    createCookie(name, "", -1);
}

function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

function yazma(evt) {
    return false;
}

function clickButton(e, buttonid) {
    var evt = e ? e : window.event;
    var bt = document.getElementById(buttonid);
    if (bt) {
        if (evt.keyCode === 13) {
            bt.click();
            return false;
        }
    }
}

$(document).ajaxStart(function () {
    $('#divProgress').css("display", "block");
});

$(document).ajaxStop(function () {
    $('#divProgress').css("display", "none");
});

$.ajaxSetup({
    beforeSend: function () {
        // show progress spinner
    },
    complete: function () {
        // hide progress spinner
    }
});

function xhrDownloadUpload() {
    var xhr = new window.XMLHttpRequest();
    //Upload progress
    xhr.upload.addEventListener("progress", function (evt) {
        //$('#divProgress').css("display", "block");
    }, false);
    //Download progress
    xhr.addEventListener("progress", function (evt) {
        //$('#divProgress').css("display", "block");
    }, false);
    //Complated
    xhr.addEventListener("load", function (evt) {
        //$('#divProgress').css("display", "none");
    }, false);
    return xhr;
}

function xhrTicket(xhr) {
    xhr.setRequestHeader("STicket", window.localStorage["token"]);
    xhr.setRequestHeader("sulLogin", readCookie("sulLogin"));
    xhr.setRequestHeader("sulLoginR", readCookie("sulLoginR"));
}

function initDt(ordercolumn,autowidth,search,page) {
    $('#dtTable').DataTable({
        "autoWidth": autowidth,
        "paging": page,
        "ordering": true,
        "info": false,
        "searching": search,
        "language": defaultDtLang,
        "order": [[ordercolumn, "asc"]]
    });
}

var defaultDtLang = {
    //"search": "Arama:",
    "search": "_INPUT_",
    "searchPlaceholder": "Arama",
    "zeroRecords": "Kay&#305;t yok",
    "loadingRecords": "Y&#252;kleniyor...",
    "processing": "Y&#252;kleniyor...",
    "paginate": {
        "first": "&#304;lk Sayfa",
        "last": "Son Sayfa",
        "next": "Sonraki",
        "previous": "&#214;nceki"
    },
    "lengthMenu": "",
    "buttons": {
        print: 'Yazd&#305;r'
    }
};

var inceleonaylasilcolumns = [
    {
        "data": "intUrunID", "class": "bgwhite keyTd hidewhenmobile", render: function (data, type, row) {
            return '<div class="imgKucRes"><img class="urunResim lazyload" rel="' + apiurl + 'resim/getT/' + data + '" src="data:image/gif;base64,R0lGODdhAQABAPAAAMPDwwAAACwAAAAAAQABAAACAkQBADs=" data-src="' + apiurl + 'resim/getTO/' + data + '" /></div>';
        }
    },
    {
        "data": "intUrunID", "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "data": "malzeme", "class": "valueTd", render: function (data, type, row) {
            return '<span class="sinirli malacik">' + data.malacik + '</span>';
        }
    },
    {
        "data": "mnFiyat", "class": "floaTd hidewhenmobile", render: function (data, type, row) {
            return '<span class="sinirli netkdv">' + data.formatMoney(2, ',', '.') + '</span>';
        }
    },
    {
        "data": null, "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data.intMiktar + ' (' + (data.strMiktarTur === "KI" ? 'kl' : 'ad') + ')' + '</span>';
        }
    },
    {
        "data": null, "class": "floaTd hidewhenmobile", render: function (data, type, row) {
            return '<span class="sinirli">' + (data.mnFiyat * data.intMiktar).formatMoney(2, ',', '.') + '</span>';
        }
    }
];

var aktinceleonaylasilcolumns = [
    {
        "data": "intUrunID", "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "data": "intUrunID", "class": "bgwhite keyTd", render: function (data, type, row) {
            return '<div class="imgKucRes"><img class="urunResim" rel="' + apiurl + 'resim/getT/' + data + '" src="' + apiurl + 'resim/getTO/' + data + '" /></div>';
        }
    },
    {
        "data": "malzeme", "class": "valueTd", render: function (data, type, row) {
            return '<span class="sinirli malacik">' + data.malacik + '</span>';
        }
    },
    {
        "data": "mnBirimFiyatKDVli", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli netkdv">' + data.formatMoney(2, ',', '.') + '</span>';
        }
    },
    {
        "data": "strAciklama1", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + parseFloat(data).formatMoney(1, ',', '.') + '</span>';
        }
    },
    {
        "data": "strAciklama2", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + parseFloat(data).formatMoney(1, ',', '.') + '</span>';
        }
    },
    {
        "data": "flCiroPrimDonusYuzde", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data.formatMoney(1, ',', '.') + '</span>';
        }
    },
    {
        "data": "flEkIsk", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data.formatMoney(1, ',', '.') + '</span>';
        }
    },
    {
        "data": "mnTutar", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data.formatMoney(2, ',', '.') + '</span>';
        }
    },
    /*{
        "data": null, "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + (data.mnDusulmusBirimFiyatKDVli / (100 + data.malzeme.kdv) * 100).formatMoney(2, ',', '.') + '</span>';
        }
    },*/
    {
        "data": "mnDusulmusBirimFiyatKDVli", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data.formatMoney(2, ',', '.') + '</span>';
        }
    }
];

var aktiviteicerikcolumns = [
    {
        "mDataProp": "itemref", title: "Kod", "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli itemref">' + data + '</span>';
        }
    },
    {
        "mDataProp": "malacik", title: "Malzeme", "class": "valueTd", render: function (data, type, row) {
            return '<span class="sinirli malacik">' + data + '</span>';
        }
    },
    {
        "mDataProp": "miktar", title: "S.H.", "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + ' koli</span>';
        }
    },
    {
        "mDataProp": "birimfiyat", title: "B.F.", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli netkdv">' + parseFloat(data).formatMoney(3, ',', '.') + '</span>';
        }
    },
    {
        "mDataProp": "fatalt", title: "F.A.", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "mDataProp": "fataltciro", title: "F.A.C.", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "mDataProp": "ciroprim", title: "C.P.D.", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "mDataProp": "iskonto", title: "Isk.", "class": "keyTd", render: function (data, type, row) {
            return '<input type="number" class="inputSecim" value="' + data + '" />';
        }
    },
    {
        "mDataProp": null, title: "C.P.T.", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + iskDusCoklu(data.birimfiyat, data.fatalt, data.fataltciro, data.iskonto, data.ciroprim).formatMoney(3, ',', '.') + '</span>';
        }
    },
    {
        "mDataProp": null, title: "KDV'siz", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + kdvDus(iskDusCoklu(data.birimfiyat, data.fatalt, data.fataltciro, data.iskonto, 0), data.kdv).formatMoney(3, ',', '.') + '</span>';
        }
    },
    {
        "mDataProp": null, title: "KDV'li", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + iskDusCoklu(data.birimfiyat, data.fatalt, data.fataltciro, data.iskonto, 0).formatMoney(3, ',', '.') + '</span>';
        }
    },
    {
        "mDataProp": null, title: "", "class": "keyTd", render: function (data, type, row) {
            return '<input type="button" class="btn btn-danger" value="Sil" onclick="urunSil(' + data.itemref + ')" />';
        }
    }
];

var aktivitecolumns = [
    {
        "data": null, "class": "bgwhite keyTd hidewhenmobile", render: function (data, type, row) {
            if (data.odemE_GUN > 0)
                return '<div class="imgKucRes"><img class="urunResim lazyload" rel="' + apiurl + 'resim/getT/' + data.itemref + '" src="data:image/gif;base64,R0lGODdhAQABAPAAAMPDwwAAACwAAAAAAQABAAACAkQBADs=" data-src="' + apiurl + 'resim/getTO/' + data.itemref + '" /></div>';
            else
                return '<div style="width:100px; height:100px" />';
        }
    },
    {
        "data": "itemref", "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "data": "malacik", "class": "valueTd", render: function (data, type, row) {
            return '<span class="sinirli malacik">' + data + '</span>';
        }
    },
    {
        "data": null, "class": window.location.href.indexOf("Iade") > -1 ? "floaTd hide" : "floaTd hidewhenmobile", render: function (data, type, row) {
            return '<span class="sinirli net" hidden>' + data.net + '</span><span class="sinirli netkdv">' + data.netkdv.toFixed(2) + '</span>';
        }
    },
    {
        "data": null, "class": "keyTd", render: function (data, type, row) {
            return '<input type="hidden" class="grupkod" value="' + data.grupkod + '">' + '</input>' +
                '<input type="number" class="inputSecim" accesskey="' + data.itemref + ';;;' + data.fiyat + '" onkeyup="clickButton(event,\'sipAktar\')" />';
        }
    },
    {
        "data": "itemref", "class": "keyTd hidewhenmobile", render: function (data, type, row) {
            return '<select class="ddTur">' + (window.location.href.indexOf("Aktivite") > -1 ? '' : '<option value="ST" selected="selected">Adet</option>') + '<option value="KI">Koli</option></select>';
        }
    }
];

var siparisiadeaktivitecolumns = [
    {
        "data": null, "class": "bgwhite keyTd hidewhenmobile", render: function (data, type, row) {
            if (data.odemE_GUN > 0)
                return '<div class="imgKucRes"><img class="urunResim lazyload" rel="' + apiurl + 'resim/getT/' + data.itemref + '" src="data:image/gif;base64,R0lGODdhAQABAPAAAMPDwwAAACwAAAAAAQABAAACAkQBADs=" data-src="' + apiurl + 'resim/getTO/' + data.itemref + '" /></div>';
            else
                return '<div style="width:100px; height:100px" />';
        }
    },
    {
        "data": "itemref", "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "data": "malacik", "class": "valueTd", render: function (data, type, row) {
            return '<span class="sinirli malacik">' + data + '</span>';
        }
    },
    {
        "data": "netkdv", "class": window.location.href.indexOf("Iade") > -1 ? "floaTd hide" : "floaTd hidewhenmobile", render: function (data, type, row) {
            return '<span class="sinirli netkdv">' + data.toFixed(2) + '</span>';
        }
    },
    {
        "data": "itemref", "class": "keyTd", render: function (data, type, row) {
            return '<input type="number" class="inputSecim" accesskey="' + data + '" onkeyup="clickButton(event,\'sipAktar\')" />';
        }
    },
    {
        "data": "itemref", "class": "keyTd hidewhenmobile", render: function (data, type, row) {
            return '<select class="ddTur">' + (window.location.href.indexOf("Aktivite") > -1 ? '' : '<option value="ST" selected="selected">Adet</option>') + (window.location.href.indexOf("Iade") > -1 ? '' : '<option value="KI">Koli</option></select>');
        }
    }
];

var siparisiadeaktiviteicerikcolumns = [
    {
        "mDataProp": "itemref", title: "Kod", "class": "keyTd", render: function (data, type, row) {
            return '<span class="sinirli itemref">' + data + '</span>';
        }
    },
    {
        "mDataProp": "malacik", title: "Malzeme", "class": "valueTd", render: function (data, type, row) {
            return '<span class="sinirli">' + data + '</span>';
        }
    },
    {
        "mDataProp": "netkdv", title: "Fiyat", "class": window.location.href.indexOf("Iade") > -1 ? "hide" : "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + parseFloat(data).formatMoney(2, ',', '.') + '</span>';
        }
    },
    {
        "mDataProp": "miktar", title: "", "class": "keyTd", render: function (data, type, row) {
            return '<input type="number" class="inputSecim" value="' + data + '" />';
        }
    },
    {
        "mDataProp": "miktartur", title: "Tip", "class": "keyTd", render: function (data, type, row) {
            return '<span class="spMiktarTur" rel="' + data + '">' + (data === 'ST' ? '(ad)' : '(kl)') + '</span>';
        }
    },
    {
        "mDataProp": "isk1", title: "i1", "class": window.location.href.indexOf("fiyattipi=2") > -1 ? "keyTd" : "hide", render: function (data, type, row) {
            return '<input type="number" class="inputSecim" value="' + data.toFixed(2) + '" disabled />';
        }
    },
    {
        "mDataProp": "isk2", title: "i2", "class": window.location.href.indexOf("fiyattipi=2") > -1 ? "keyTd" : "hide", render: function (data, type, row) {
            return '<input type="number" class="inputSecim" value="' + data.toFixed(2) + '" disabled />';
        }
    },
    {
        "mDataProp": "isk3", title: "i3", "class": window.location.href.indexOf("fiyattipi=2") > -1 ? "keyTd" : "hide", render: function (data, type, row) {
            return '<input type="number" class="inputSecim" value="' + data.toFixed(2) + '" disabled />';
        }
    },
    {
        "mDataProp": "isk4", title: "i4", "class": window.location.href.indexOf("fiyattipi=2") > -1 ? "keyTd" : "hide", render: function (data, type, row) {
            return '<input type="number" class="inputSecim" value="' + data.toFixed(2) + '" disabled />';
        }
    },
    {
        "mDataProp": null, title: "Top.", "class": "floaTd", render: function (data, type, row) {
            return '<span class="sinirli">' + parseFloat(parseFloat(data.netkdv) * parseFloat(data.miktar)).formatMoney(2, ',', '.') + '</span>';
        }
    },
    {
        "mDataProp": null, title: "", "class": "keyTd", render: function (data, type, row) {
            return '<input type="button" class="btn btn-danger" value="Sil" onclick="urunSil(' + data.itemref + ', \'' + data.miktartur + '\')" />';
        }
    }
];

function checkAuth(obj) {
    /*$.ajax(
        {
            xhr: function () { return xhrDownloadUpload(); },
            beforeSend: function (xhr) { xhrTicket(xhr); },
            url: apiurl + "genel/auth",
            success: function (data, textStatus, response) {
                checkAuth2(response);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) { console.log('hata'); }
        }
    );*/
}

function checkAuth2(obj) {
    if (obj.getResponseHeader("auth") === "notlogged") {
        window.localStorage.removeItem("eposta");
        window.localStorage.removeItem("sifre");
        window.localStorage.removeItem("uyeid");
        window.localStorage.removeItem("uyetipiid");
        window.localStorage.removeItem("slsref");
        window.localStorage.removeItem("gmref");
        window.localStorage.removeItem("token");
        window.localStorage.removeItem("musteri");
        eraseCookie("sulLogin");
        eraseCookie("sulLoginR");

        console.log("not logged");
        var htt = window.location.href.substring(0, window.location.href.indexOf(":"));
        var adres = window.location.href.replace("https://", "").replace("http://", "");
        var bas = adres.indexOf("site") > -1 ? adres.substring(0, adres.indexOf("/")) + "/site" : adres.substring(0, adres.indexOf("/"));
        window.location.href = htt + "://" + bas + "/?returnurl=" + escape(adres.substring(adres.indexOf("/", bas.length) + 1));
    }
    else {
        window.localStorage["token"] = obj.getResponseHeader("yeniticket");
        createCookie("sulLogin", obj.getResponseHeader("yeniticket2"), 1);
    }
}

function showSubMenu(contr) {
    boslukTiklandi();
    for (var i = 0; i < contr.length; i++) {
        var openDropdown = contr[i];
        if (openDropdown.classList.contains('show')) {
            openDropdown.classList.remove('show');
        }
    }
    contr.classList.toggle("show");
}

function boslukTiklandi() {
        var dropdowns = document.getElementsByClassName("subMenu");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
}

Array.prototype.removeValue = function (name, value, name2, value2) {
    var array = $.map(this, function (v, i) {
        return v[name] === value && v[name2] === value2 ? null : v;
    });
    this.length = 0;
    this.push.apply(this, array);
};

Array.prototype.updateValue = function (colname, colnamevalue, col2name, col2namevalue, chcolname, chcolnamevalue) {
    this.forEach(function (result, index) {
        if (result[colname] === colnamevalue && result[col2name] === col2namevalue) {
            result[chcolname] = chcolnamevalue;
        }
    });
};

Number.prototype.formatMoney = function (fractionDigits, decimal, separator) {
    fractionDigits = isNaN(fractionDigits = Math.abs(fractionDigits)) ? 2 : fractionDigits;

    decimal = typeof (decimal) === "undefined" ? "." : decimal;

    separator = typeof (separator) === "undefined" ? "," : separator;

    var number = this;

    var neg = number < 0 ? "-" : "";

    var wholePart = parseInt(number = Math.abs(+number || 0).toFixed(fractionDigits)) + "";

    var separtorIndex = (separtorIndex = wholePart.length) > 3 ? separtorIndex % 3 : 0;

    return neg +

        (separtorIndex ? wholePart.substr(0, separtorIndex) + separator : "") +

        wholePart.substr(separtorIndex).replace(/(\d{3})(?=\d)/g, "$1" + separator) +

        (fractionDigits ? decimal + Math.abs(number - wholePart).toFixed(fractionDigits).slice(2) : "");

};

$.event.special.inputchange = {
    setup: function () {
        var self = this, val;
        $.data(this, 'timer', window.setInterval(function () {
            val = self.value;
            if ($.data(self, 'cache') !== val) {
                $.data(self, 'cache', val);
                $(self).trigger('inputchange');
            }
        }, 20));
    },
    teardown: function () {
        window.clearInterval($.data(this, 'timer'));
    },
    add: function () {
        $.data(this, 'cache', this.value);
    }
};

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

//function getBosSepet() {
//    var sepet = [{ siparisid: 0, smref: 0, itemref: 0, malacik: "", netkdv: 0, miktar: 0, miktartur: "" }];
//    sepet.removeValue('itemref', 0, 'miktartur', "");
//    return sepet;
//}

function stringifySepet(sepet, smref, fiyattipi, siparisid) {
    var sentValue;
    for (var i = 0; i < sepet.length; i++) {
        if (sepet[i].smref === smref && sepet[i].ftip === fiyattipi && sepet[i].siparisid === siparisid) {
            var sepet2 = sepet[i];
            sepet2.musteri = window.localStorage["uyeid"];
            sentValue = JSON.stringify(sepet2);
            break;
        }
    }
    return sentValue;
}

function stringifySepetI(sepet, smref, iadeid) {
    var sentValue;
    for (var i = 0; i < sepet.length; i++) {
        if (sepet[i].smref === smref && sepet[i].iadeid === iadeid) {
            var sepet2 = sepet[i];
            sepet2.musteri = window.localStorage["uyeid"];
            sentValue = JSON.stringify(sepet2);
            break;
        }
    }
    return sentValue;
}

function stringifySepetA(sepet, smref, donem, tip, aktiviteid, anlasmaid) {
    var sentValue = '';
    for (var i = 0; i < sepet.length; i++) {
        if (sepet[i].smref === smref && sepet[i].donem === donem && sepet[i].tip === tip && sepet[i].aktiviteid === aktiviteid && sepet[i].anlasmaid === anlasmaid) {
            sentValue = '{ "id": ' + sepet[i].aktiviteid + ', "musteri": "' + window.localStorage["uyeid"] + '", "smref": ' + sepet[i].smref + ', "fiyattipi": ' + sepet[i].ftip + ', "aktivitetipi": ' + sepet[i].tip + ', "anlasmaid": ' + sepet[i].anlasmaid + ', "donem": "' + sepet[i].donem + '", "baslangic": "' + sepet[i].baslangic + '", "bitis": "' + sepet[i].bitis + '", "aciklama1": "' + sepet[i].aciklama1 + '", "aciklama2": "' + sepet[i].aciklama2 + '", "aciklama3": "' + sepet[i].aciklama3 + '", "detaylar": [';
            for (var j = 0; j < sepet[i].detaylar.length; j++) {
                sentValue += '{ "urun": ' + sepet[i].detaylar[j].itemref + ', "urunacik": "' + sepet[i].detaylar[j].malacik + '", "kdv": ' + sepet[i].detaylar[j].kdv + ', "miktar": ' + sepet[i].detaylar[j].miktar + ', "aksiyon": 0, "birimfiyat": ' + sepet[i].detaylar[j].birimfiyat + ', "fatalt": ' + sepet[i].detaylar[j].fatalt + ', "fataltciro": ' + sepet[i].detaylar[j].fataltciro + ', "ciroprim": ' + sepet[i].detaylar[j].ciroprim + ', "pazisk": ' + sepet[i].detaylar[j].pazisk + ', "ekisk": ' + sepet[i].detaylar[j].iskonto + ' },';
            }
            sentValue = sentValue.substring(0, sentValue.length - 1) + '] }';
        }
    }
    return sentValue;
}

function aktSil(cookie) {
    var yenicookie = [];
    for (var i = 0; i < cookie.length; i++) {
        if (cookie[i].smref === paramsmref && cookie[i].tip === paramtip && cookie[i].donem === paramdonem && cookie[i].aktiviteid === aktiviteid && cookie[i].anlasmaid === anlasmaid) {
            var asd = cookie[i].smref;
        }
        else {
            yenicookie.push({
                aktiviteid: cookie[i].aktiviteid,
                anlasmaid: cookie[i].anlasmaid,
                ahtfatalt: cookie[i].ahtfatalt,
                ahtfataltciro: cookie[i].ahtfataltciro,
                ahtciroprim: cookie[i].ahtciroprim,
                yegfatalt: cookie[i].yegfatalt,
                yegfataltciro: cookie[i].yegfataltciro,
                yegciroprim: cookie[i].yegciroprim,
                smref: cookie[i].smref,
                ftip: cookie[i].ftip,
                tip: cookie[i].tip,
                donem: cookie[i].donem,
                baslangic: cookie[i].baslangic,
                bitis: cookie[i].bitis,
                aciklama1: cookie[i].aciklama1,
                aciklama2: cookie[i].aciklama2,
                aciklama3: cookie[i].aciklama3,
                detaylar: cookie[i].detaylar
            });
        }
    }
    window.localStorage['sepetA'] = JSON.stringify(yenicookie);
}

function sipSil(cookie) {
    var yenicookie = [];
    for (var i = 0; i < cookie.length; i++) {
        if (cookie[i].smref === paramsmref && cookie[i].ftip === paramftip && cookie[i].siparisid === siparisid) {
            var asd = cookie[i].smref;
        }
        else {
            yenicookie.push({
                siparisid: cookie[i].siparisid,
                smref: cookie[i].smref,
                ftip: cookie[i].ftip,
                aciklama: cookie[i].aciklama,
                teslim: cookie[i].teslim,
                detaylar: cookie[i].detaylar
            });
        }
    }
    window.localStorage['sepet'] = JSON.stringify(yenicookie);
    window.localStorage['sepetU'] = "[]";
}

function iadeSil(cookie) {
    var yenicookie = [];
    for (var i = 0; i < cookie.length; i++) {
        if (cookie[i].smref === paramsmref && cookie[i].iadeid === iadeid) {
            var asd = cookie[i].smref;
        }
        else {
            yenicookie.push({
                iadeid: cookie[i].iadeid,
                smref: cookie[i].smref,
                aciklama: cookie[i].aciklama,
                detaylar: cookie[i].detaylar
            });
        }
    }
    window.localStorage['sepetI'] = JSON.stringify(yenicookie);
}

Date.prototype.addHours = function (h) {
    this.setTime(this.getTime() + (h * 60 * 60 * 1000));
    return this;
};

function getDateNow() {
    var date = new Date();
    return new Date(date.getTime() - (date.getTimezoneOffset() * 60000)).toJSON();
}

function GetDateNow() {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1;
    var yyyy = today.getFullYear();

    if (dd < 10) {
        dd = '0' + dd;
    }

    if (mm < 10) {
        mm = '0' + mm;
    }

    return dd + '.' + mm + '.' + yyyy;
}

function getDateNowStr() {
    var date = new Date();
    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
    var hour = date.getHours();
    var minute = date.getMinutes();
    var second = date.getSeconds();
    
    return (day.toString().length === 2 ? day : "0" + day) + "." + (month.toString().length === 2 ? month : "0" + month) + "." + year + "." +
        (hour.toString().length === 2 ? hour : "0" + hour) + ':' + (minute.toString().length === 2 ? minute : "0" + minute) + ':' + (second.toString().length === 2 ? second : "0" + second);
}

function KoordinatBaslat() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(positionSuccess, displayError, { maximumAge: 60000, timeout: 10000, enableHighAccuracy: false });
    } else {
        document.getElementById('inputCoords').value = '0,0';
        document.getElementById('inputCoordAddress').value = 'Konuma erişim desteklenmiyor.';
    }
}

function displayError(positionError) {
    var mapProp = { center: { lat: 39.0100679, lng: 34.2481206 }, zoom: 6, styles: JSON.parse(MapStyle()) };
    map = new google.maps.Map(document.getElementById("divMap"), mapProp);

    switch (positionError.code) {
        case positionError.PERMISSION_DENIED:
            document.getElementById('inputCoords').value = "0,0";
            document.getElementById('inputCoordAddress').value = "-Konuma Erisilemedi-(1)";
            break;
        case positionError.POSITION_UNAVAILABLE:
            document.getElementById('inputCoords').value = "0,0";
            document.getElementById('inputCoordAddress').value = "-Konuma Erisilemedi-(2)";
            break;
        case positionError.TIMEOUT:
            document.getElementById('inputCoords').value = "0,0";
            document.getElementById('inputCoordAddress').value = "-Konuma Erisilemedi-(3)";
            break;
        case positionError.UNKNOWN_ERROR:
            document.getElementById('inputCoords').value = "0,0";
            document.getElementById('inputCoordAddress').value = "-Konuma Erisilemedi-(3)";
            break;
    }
}

function positionSuccess(position) {
    var coords = position.coords || position.coordinate || position;
    var latLng = new google.maps.LatLng(coords.latitude, coords.longitude);
    document.getElementById('inputCoords').value = coords.latitude.toFixed(6) + ',' + coords.longitude.toFixed(6);
    document.getElementById('inputCoordsLat').value = coords.latitude.toFixed(6);
    document.getElementById('inputCoordsLng').value = coords.longitude.toFixed(6);
    document.getElementById('inputCoordAddress').value = 'Araniyor: ' + coords.latitude + ', ' + coords.longitude + '...';
    myMap();
    (new google.maps.Geocoder()).geocode({ latLng: latLng }, function (resp) {
        document.getElementById('inputCoordAddress').value = resp[0].formatted_address;
        setTimeout(function () {
            try {
                Sonlanmamis();
            } catch (e) {

            }
        }, 200);
        $('.konumTamam').prop('disabled', false);
    });
}

function MapStyle() {
    return '[{ "featureType": "landscape", "elementType": "geometry", "stylers": [{ "saturation": "-100"}] }, { "featureType": "poi", "elementType": "labels", "stylers": [{ "visibility": "on"}] }, { "featureType": "poi", "elementType": "labels.text.stroke", "stylers": [{ "visibility": "on"}] }, { "featureType": "road", "elementType": "labels.text", "stylers": [{ "color": "#545454"}] }, { "featureType": "road", "elementType": "labels.text.stroke", "stylers": [{ "visibility": "off"}] }, { "featureType": "road.highway", "elementType": "geometry.fill", "stylers": [{ "saturation": "-87" }, { "lightness": "-40" }, { "color": "#ffffff"}] }, { "featureType": "road.highway", "elementType": "geometry.stroke", "stylers": [{ "visibility": "off"}] }, { "featureType": "road.highway.controlled_access", "elementType": "geometry.fill", "stylers": [{ "color": "#f0f0f0" }, { "saturation": "-22" }, { "lightness": "-16"}] }, { "featureType": "road.highway.controlled_access", "elementType": "geometry.stroke", "stylers": [{ "visibility": "off"}] }, { "featureType": "road.highway.controlled_access", "elementType": "labels.icon", "stylers": [{ "visibility": "on"}] }, { "featureType": "road.arterial", "elementType": "geometry.stroke", "stylers": [{ "visibility": "off"}] }, { "featureType": "road.local", "elementType": "geometry.stroke", "stylers": [{ "visibility": "off"}] }, { "featureType": "transit", "elementType": "labels.icon", "stylers": [{ "visibility": "off"}] }, { "featureType": "water", "elementType": "geometry.fill", "stylers": [{ "saturation": "-52" }, { "hue": "#00e4ff" }, { "lightness": "-16"}]}]';
}

var map;
var markers = [];
function myMap() {
    var marker = new google.maps.Marker({ position: { lat: parseFloat($("#inputCoordsLat").val()), lng: parseFloat($("#inputCoordsLng").val()) }, title: "Buradasiniz", label: "B" });
    var mapProp = { center: marker.position, zoom: 14, styles: JSON.parse(MapStyle()) };
    map = new google.maps.Map(document.getElementById("divMap"), mapProp);
    marker.setMap(map);
    markers.push(marker);
}

function farkHesapla(birinci, ikinci) {
    var p11 = parseFloat(birinci.substring(0, birinci.indexOf(",")));
    var p12 = parseFloat(birinci.substring(birinci.indexOf(",") + 1));
    var p21 = parseFloat(ikinci.substring(0, ikinci.indexOf(",")));
    var p22 = parseFloat(ikinci.substring(ikinci.indexOf(",") + 1));
    var p1 = new google.maps.LatLng(p11, p12);
    var p2 = new google.maps.LatLng(p21, p22);
    var mes = mesafe(p1, p2);
    if (isNaN(mes)) {
        mes = "-1";
    }
    return mes;
}

function mesafe(p1, p2) {
    var R = 6378137; // Earth’s mean radius in meter
    var dLat = this.rad(p2.lat() - p1.lat());
    var dLong = this.rad(p2.lng() - p1.lng());
    var a = Math.sin(dLat / 2) * Math.sin(dLat / 2) +
        Math.cos(this.rad(p1.lat())) * Math.cos(this.rad(p2.lat())) *
        Math.sin(dLong / 2) * Math.sin(dLong / 2);
    var c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
    var d = R * c;
    return d.toFixed(0).toString();
}

function rad(x) {
    return x * Math.PI / 180;
}

function AdresGetir(adres) {
    var geocoder = new google.maps.Geocoder();
    var address = adres;
    if (geocoder) {
        geocoder.geocode({ 'address': address }, function (results, status) {
            if (status === google.maps.GeocoderStatus.OK) {
                if (status !== google.maps.GeocoderStatus.ZERO_RESULTS) {
                    map.setCenter(results[0].geometry.location);
                    var infowindow = new google.maps.InfoWindow(
                        {
                            content: '<b>' + address + '</b>',
                            size: new google.maps.Size(150, 50)
                        });
                    var marker = new google.maps.Marker({
                        position: results[0].geometry.location,
                        map: map,
                        title: address,
                        draggable: true
                    });
                    google.maps.event.addListener(marker, 'click', function () {
                        infowindow.open(map, marker);
                        map.setZoom(16);
                        map.setCenter(marker.getPosition());
                    });
                    google.maps.event.addListener(marker, 'dragend', function (evt) {
                        document.getElementById('inputCoordsLat').value = evt.latLng.lat().toFixed(6);
                        document.getElementById('inputCoordsLng').value = evt.latLng.lng().toFixed(6);
                        document.getElementById("inputCoords").value = document.getElementById("inputCoordsLat").value + "," + document.getElementById("inputCoordsLng").value;
                        geocodePosition(evt.latLng);
                    });

                    marker.setMap(map);
                    SifirlaMarkers();
                    markers.push(marker);
                    map.setZoom(10);

                    document.getElementById("inputCoordsLat").value = results[0].geometry.location.lat().toFixed(6);
                    document.getElementById("inputCoordsLng").value = results[0].geometry.location.lng().toFixed(6);
                    document.getElementById("inputCoords").value = document.getElementById("inputCoordsLat").value + "," + document.getElementById("inputCoordsLng").value;
                    document.getElementById("inputCoordAddress").value = results[0].formatted_address;

                    $('.konumTamam').prop('disabled', false);
                } else {
                    alert("Adres bulunamadi.");
                }
            } else {
                alert("Adres bulunamadi.");
            }
        });
    }
}

function geocodePosition(pos) {
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({
        latLng: pos
    }, function (responses) {
        if (responses && responses.length > 0) {
            document.getElementById("inputCoordAddress").value = responses[0].formatted_address;
        } else {
            document.getElementById("inputCoordAddress").value = "Adres bulunamadi.";
        }
    });
}

function KayitliAdresiGetir(koordinatlar) {
    var lat = koordinatlar.split(",")[0];
    var lng = koordinatlar.split(",")[1];
    var marker = new google.maps.Marker({ position: { lat: parseFloat(lat), lng: parseFloat(lng) }, title: "", label: "", draggable: true });
    var mapProp = { center: marker.position, zoom: 14, styles: JSON.parse(MapStyle()) };
    map = new google.maps.Map(document.getElementById("divMap"), mapProp);
    geocodePosition(marker.getPosition());

    google.maps.event.addListener(marker, 'dragend', function (evt) {
        document.getElementById("inputCoords").value = evt.latLng.lat().toFixed(6) + ", " + evt.latLng.lng().toFixed(6);
        geocodePosition(evt.latLng);
        $('.konumTamam').prop('disabled', false);
    });

    google.maps.event.addListener(marker, 'click', function () {
        map.setZoom(16);
        map.setCenter(marker.getPosition());
    });

    marker.setMap(map);
    markers.push(marker);
    map.setCenter(marker.getPosition());
}

function SifirlaMarkers() {
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(null);
    }
}

function iskDusCoklu(fiyat, isk1, isk2, isk3, isk4) {
    return iskDus(iskDus(iskDus(iskDus(fiyat, isk1), isk2), isk3), isk4);
}

function iskDus(fiyat, isk) {
    return fiyat - (fiyat / 100 * isk);
}

function kdvEkle(fiyat, kdv) {
    return fiyat + (fiyat / 100 * kdv);
}

function kdvDus(fiyat, kdv) {
    return fiyat / ((100 + kdv) / 100);
}

function delay(callback, ms) {
    var timer = 0;
    return function () {
        var context = this, args = arguments;
        clearTimeout(timer);
        timer = setTimeout(function () {
            callback.apply(context, args);
        }, ms || 0);
    };
}

function AndroidToast(ileti) {
    try {
        Android.ShowToast(ileti);
    } catch (e) {
        alert(ileti);
    }
}