// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets
String.prototype.format = function() {
    return [...arguments].reduce((p,c) => p.replace(/%s/,c), this);
  };
// Write your Javascript code.
function addCard(nm, status, tratamento, bg="normal", element)
{
    var dbg  =   
    {
        n: "text-dark bg-light",
        a:  "text-white bg-warning",
        d:    "text-secondary bg-dark"
    };
    const   cardCol    =   document.createElement("div");
    cardCol.classList.add("col-sm-4");
    cardCol.innerHTML = "<div class='card %s'><div class='card-img-top' alt='Card image cap'></div><div class='card-body'><h5 class='card-title'>%s</h5><br/><label class='card-text'>Status: %s</label><br/><label class='card-text'>Tratamento/Fase: %s</label></div></div>".format(dbg[bg], nm, status, tratamento);
    element.appendChild(cardCol);
    console.log(cardCol.innerHTML);
    console.log(dbg[bg]);
}