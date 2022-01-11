$(".btn btn-primary").click(function () {
    $("#card_id").attr("value", $(this).attr("word-id"));
});

var app = new Vue({
    el: '#rename_form',
    data: {
        style_icerik: 'display: none;'
    }
});

var app2 = new Vuew({
    el: '#rename_folder',
    data: {
        message: 'degistirrrrrr'
    }
    methods: {
        m_click: function () {
            el: '#rename_form'
            this.el.style_icerik = '';
        }
    }
});