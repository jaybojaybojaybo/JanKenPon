function player1choice()
{
  if(keys[0] === true){
    document.getElementById('id1').value='c';
  } else if(keys[1] === true) {
    document.getElementById('id1').value='d';
  } else if(keys[2] === true) {
    document.getElementById('id1').value='e';
  }
};

function player2choice()
{
  if(keys[3] === true){
    document.getElementById('id2').value='c';
  } else if(keys[4] === true) {
    document.getElementById('id2').value='d';
  } else if(keys[5] === true) {
    document.getElementById('id2').value='e';
  }
};


$(document).ready(function(){
  keys = new Array(6);
  $(document).keydown(function(event) {
    var key = event.keyCode;
    //console.log("keydown" + key);
    if (key === 67) keys[0] = true;
    if (key === 68) keys[1] = true;
    if (key === 69) keys[2] = true;
    if (key === 77) keys[3] = true;
    if (key === 75) keys[4] = true;
    if (key === 79) keys[5] = true;
  });

  $(document).keyup(function(event) {
    var key = event.keyCode;
    //  console.log("keyup" + key);
    if (key === 67) keys[0] = false;
    if (key === 68) keys[1] = false;
    if (key === 69) keys[2] = false;
    if (key === 77) keys[3] = false;
    if (key === 75) keys[4] = false;
    if (key === 79) keys[5] = false;
  });
});
