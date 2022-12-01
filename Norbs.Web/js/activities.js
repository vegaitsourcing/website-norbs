$(document).ready(function () {
    $('.activity-button').on('click', function () {
        fetchActivitiesByTag($(this).text().trim());
    });
});

function fetchActivitiesByTag(tagName) {
  if (!tagName) return [];
  $.ajax({
    url: `/umbraco/surface/activitiesList/GetArticlesForTag?tagName=${tagName}`,
    accpet: 'text/html',
    success: function (response) {
        $('#activitiesList').html(response);
    },
    error: function (response) {
      console.log('Error: ' + JSON.stringify(response));
    }
  });
}