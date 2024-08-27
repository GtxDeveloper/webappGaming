(() => {


    var showPopup = (title, message, status) => {
        // bg-success
        // bg-danger
        // bg-primary
        return `<div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                      <div class="modal-dialog modal-dialog-centered" role="document">
                        <div class="modal-content">
                          <div class="modal-header ${status}">
                            <h5 class="modal-title" id="exampleModalLongTitle">${title}</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                              <span aria-hidden="true">&times;</span>
                            </button>
                          </div>
                          <div class="modal-body">
                            ${message}
                          </div>
                          <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                          </div>
                        </div>
                      </div>
                    </div>`;
    }


    var countComments = 0;
    var getCommentBox = (comment) => {
        countComments++;
        var result = `<div class="nk-comment">
                        <div class="nk-comment-meta">
                            <input type='hidden' class='commentId' value='${comment.Id}'/>
                            <img src="${comment.VisitorAvatar}" alt="" class="rounded-circle" width="35">
                                by <a href="#">${comment.VisitorName}</a> in ${comment.DateOfCreated}
                            <button class="nk-btn nk-btn-rounded nk-btn-color-dark-3 float-right replyButton">Reply</button>
                        </div>
                        <div class="nk-comment-text">
                            <p>${comment.Text}</p>
                        </div>`;
            for (var i = 0; i < comment.Childs.length; i++) {
                result += getCommentBox(comment.Childs[i]);
            }
            result+=`</div >`;

        return result;
    }
    let postId = parseInt($('#postId').val())
    $.ajax({
        url: '/ajax/GetAllComments',                            /* Куда отправить запрос                                     */
        method: 'get',                                          /* Метод запроса (post или get)                              */
        dataType: 'json',                                       /* Тип данных в ответе (xml, json, script, html).            */
        data: { 'postId': postId },                             /* Данные передаваемые в массиве                             */
        success: function (comments) {                          /* функция которая будет выполнена после успешного запроса.  */
                //console.dir(data);                            /* В переменной data содержится ответ от index.php.          */

            var $commentsContainer = $('#comments');

            comments.forEach((comm, index) => {
                $commentsContainer.append(getCommentBox(comm))
            })
            $('#countCommentBox').text(countComments);

            var parentId = null;
            var parentBlock = null;
            $('.replyButton').each((index, item) => {
                $(item).on('click', (e) => {
                    var $commBlock = $(item).closest('.nk-comment');
                    if (parentBlock == null) {
                        $(item).addClass('selected-comment');
                        parentId = $commBlock.find('.commentId').val();
                        parentBlock = $(item);
                    } else if ($(item).is(parentBlock)) {
                        parentBlock.removeClass('selected-comment');
                        parentId = null;
                        parentBlock = null;
                    } else {
                        parentBlock.removeClass('selected-comment');
                        $(item).addClass('selected-comment');
                        parentId = $commBlock.find('.commentId').val();
                        parentBlock = $(item);
                    }
                })
            })

            var $sendCommentForm = $('.sendCommentForm')
            $sendCommentForm.find('.button-send-comment').on('click', () => {

                var vName = $sendCommentForm.find('input[name="VisitorName"]').val();
                var vEmail = $sendCommentForm.find('input[name="VisitorEmail"]').val();
                var vText = $sendCommentForm.find('textarea[name="Text"]').val();

                // 1. валидация данных !!!!!!!

                var requestMessage = {
                    PostId: postId,
                    ParentId: parentId,
                    VisitorName: vName,
                    VisitorEmail: vEmail,
                    Text: vText
                }

                $.ajax({
                    url: '/ajax/SaveComment',                            /* Куда отправить запрос                                     */
                    method: 'post',                                      /* Метод запроса (post или get)                              */
                    dataType: 'json',                                    /* Тип данных в ответе (xml, json, script, html).            */
                    data: requestMessage,                                /* Данные передаваемые на сервер                             */
                    success: function (response) {                       /* функция которая будет выполнена после успешного запроса.  */
                        response = JSON.parse(response);
                        switch (response.status) {
                            case "error": {
                                $(document.body).append(showPopup("Ошибка", "Комментарий не был отправлен. Попробуйте позже.", 'bg-danger'))
                                
                                break;
                            }
                            case "succsess": {
                                $(document.body).append(showPopup("Успех", "Комментарий был отправлен на модерацию. И будет отображен после проверки", 'bg-success'))
                                $sendCommentForm.trigger("reset");
                                break;
                            }
                            default: {
                                $(document.body).append(showPopup("Системная ошибка", "На сайте техническуие неполадки. Администраторы уже выехали", 'bg-warning'))
                            }
                        }
                        $('#exampleModalCenter').modal("show");
                    }
                })
            })
        }
    });
})()