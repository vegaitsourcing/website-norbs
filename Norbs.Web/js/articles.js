$(document).ready(function () {
    let firstTab = $('.tab-list button').first();
    firstTab.addClass('tab--active');
    fetchAndRenderArticlesForTag(firstTab.text());
    $('.js-tab').on('click', function () {
        if ($(this).hasClass('tab--active')) {
            fetchAndRenderArticlesForTag($(this).text());
        }
    });
});

function renderArticles(articles) {
    $('.tabs-block__holder-cards').empty();
    $('.tabs-block__holder-cards').html(articles);
}

function fetchAndRenderArticlesForTag(tagName) {
    if (!tagName) return [];
    $.ajax({
        type: 'GET',
        url: '/articles/getForTag',
        data: { tagName: tagName },
        success: function (response) {
            renderArticles(response);
        },
        error: function (response) {
            console.log('Error: ' + JSON.stringify(response));
        }
    });
}