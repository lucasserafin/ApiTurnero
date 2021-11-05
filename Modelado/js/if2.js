function valida() {


                if (document.frm.sel.value == "opcion")
                    swal({title: "ERROR",
                        text: "Seleccione ORIGEN ",

                        confirmButtonColor: "#a1",
                        showConfirmButton: true});
              else  if (document.frm1.sel2.value == "opcion")
                    swal({title: "ERROR",
                        text: "Seleccione DESTINO ",

                        confirmButtonColor: "#a1",
                        showConfirmButton: true});

            else    if ((document.frm.sel.value == "opcion12") && (document.frm1.sel2.value == "opcion28")){
                    window.location = "esperanzasantafe.html";
                    const button = document.querySelector('.eael-load-more-button');

button.addEventListener('click', simulateLoad);
button.addEventListener('touchend', simulateLoad);

function simulateLoad() {
  button.classList.add('button--loading');
  button.querySelector('span').innerHTML = 'Cargando...';
}}
            else    if ((document.frm.sel.value == "opcion12") && (document.frm1.sel2.value == "opcion21")){
                    window.location = "esperanzarafaela.html"
                    const button = document.querySelector('.eael-load-more-button');

button.addEventListener('click', simulateLoad);
button.addEventListener('touchend', simulateLoad);

function simulateLoad() {
  button.classList.add('button--loading');
  button.querySelector('span').innerHTML = 'Cargando...';
}}



                   else  if ((document.frm.sel.value == "opcion01") && (document.frm1.sel2.value == "opcion02")){
                    window.location = "resultados/cordobasalta.html";                    const button = document.querySelector('.eael-load-more-button');

button.addEventListener('click', simulateLoad);
button.addEventListener('touchend', simulateLoad);

function simulateLoad() {
  button.classList.add('button--loading');
  button.querySelector('span').innerHTML = 'Cargando...';
}}

             else   if ((document.frm.sel.value == "opcion01") && (document.frm1.sel2.value == "opcion01")){
                    window.location = "resultados/cordobabuenosaires.html";                    const button = document.querySelector('.eael-load-more-button');

button.addEventListener('click', simulateLoad);
button.addEventListener('touchend', simulateLoad);

function simulateLoad() {
  button.classList.add('button--loading');
  button.querySelector('span').innerHTML = 'Cargando...';
}}

             

else {
  swal({title: "ERROR",
                        text: "Cordoba debe ser ORIGEN o DESTINO",

                        confirmButtonColor: "#a1",
                        showConfirmButton: true});
}}