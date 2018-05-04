$(document).ready(init);

function init() {
    $('#addPost').click(function () {
        let Descripcion = $('#tPostear').val();
        let d = new Date();
        let date = d.toLocaleDateString();
        let form = new FormData();
        form.append('Date', date);
        form.append('Descripcion', Descripcion);

        fetch('Post.aspx?fid=Addpost', {
            method: 'POST',
            body: form,
            credentials:'include'
        }).then(function () {
            $('#tPostear').val('');
            MostrarPublicaciones()

            }).catch(function (error) {
            console.log('request failed', error)
            }) 

    });

    MostrarPublicaciones()
}

function MostrarPublicaciones() {
    fetch('Post.aspx?fid=getposts')
        .then(function (response) {
            return response.json()
        }).then(crearPublicacion)
.catch(function (ex) {
            console.log('parsing failed', ex)
        });

};



function crearPublicacion(json) {
    $(json.map(publicacion =>
        `<div id="post">
                <div class="post-container">
                        <ul id="post-list" class="post-list">
		                   <li>
                               <div class="comment-main-level">
			                        <!-- Avatar -->
		                           <div class="comment-avatar"><img src="http://i9.photobucket.com/albums/a88/creaticode/avatar_1_zps8e1c80cd.jpg" alt=""></div>
					                            <!-- Contenedor del Comentario -->
			                           <div class="comment-box">
		    	                            <div class="comment-head">
						                        <h6 class="comment-name by-author"><a href="http://creaticode.com/blog">${publicacion.NombreCompleto}</a></h6>
						                            <span>${publicacion.Fecha}</span>
							                        <i class="fa fa-reply"></i>
							                        <i class="fa fa-heart"></i>
					                        </div>
					                        <div class="comment-content">
                                                    ${publicacion.Descripcion}
                                            </div>
                                       </div>
	                              </div>
                                </li>
                            </ul>
                      </div>
     </div>
<div class="comments-container">
<h3>Comentarios</h3'>
${(publicacion.Comentarios.length == 0) ? `<textarea></textarea><button>Comentar</button></div>` : `<ul id="comments-list" class="comments-list">
			    <li>
				    <div class="comment-main-level">
 ${publicacion.Comentarios.map(comentario => `
					    <!-- Avatar -->
					    <div class="comment-avatar"><img src="http://i9.photobucket.com/albums/a88/creaticode/avatar_1_zps8e1c80cd.jpg" alt=""></div>
					    <!-- Contenedor del Comentario -->
					    <div class="comment-box">
						    <div class="comment-head">
							    <h6 class="comment-name by-author"><a href="http://creaticode.com/blog">${comentario.NombreCompleto}</a></h6>
							    <span>hace 20 minutos</span>
							    <i class="fa fa-reply"></i>
							    <i class="fa fa-heart"></i>
						    </div>
						    <div class="comment-content">
							   ${comentario.Descripcion} 
						    </div>
					    </div>
				    </div>${(publicacion.Comentarios.Respuestas.length == 0) ? `<textarea></textarea><button>Comentar</button></div>` : `
<!-- Respuestas de los comentarios -->
				    <ul class="comments-list reply-list">
${publicacion.Comentarios.Respuestas.map(respuesta => `
					    <li>
						    <!-- Avatar -->
						    <div class="comment-avatar"><img src="http://i9.photobucket.com/albums/a88/creaticode/avatar_2_zps7de12f8b.jpg" alt=""></div>
						    <!-- Contenedor del Comentario -->
						    <div class="comment-box">
							    <div class="comment-head">
								    <h6 class="comment-name"><a href="http://creaticode.com/blog">${respuesta.NombreCompleto}</a></h6>
								    <span>hace 10 minutos</span>
								    <i class="fa fa-reply"></i>
								    <i class="fa fa-heart"></i>
							    </div>
							    <div class="comment-content">
								    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Velit omnis animi et iure laudantium vitae, praesentium optio, sapiente distinctio illo?
							    </div>
						    </div>
					    </li>`)}`}
				    </ul>

			    </li>
		    </ul> `)}  `}
<textarea></textarea><button>Comentar</button>
	    </div>`).join('')).appendTo('#miContenido');
    console.log('parsed json', json)
};
/*  */

/*function checkStatus(response) {
    if (response.status >= 200 && response.status < 300) {
        return response
    } else {
        var error = new Error(response.statusText)
        error.response = response
        throw error
    }
}

function parseJSON(response) {
    return response.json()
}

fetch('/users')
    .then(checkStatus)
    .then(parseJSON)
    .then(function (data) {
        console.log('request succeeded with JSON response', data)
    }).catch(function (error) {
        console.log('request failed', error)
    })*/