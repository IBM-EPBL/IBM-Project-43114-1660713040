 html, body 
	{
    	height: 100%;
		margin: 0px;
		padding:0px;
	}
#container
{
	display: flex;
	flex-direction: row;
	height: 100%;
	width: 100%;
	position: relative;
}
#logo_container
{
	height: 100%;
	width: 12%;
	background-color: #C5C6D0;
	display: flex;
	flex-direction: column;
	vertical-align: text-bottom;
}
.logo
{
	width:70%;
	margin: 5% 15%;
	
/* 	border-radius: 50%; */
}
#logo_3
{
	vertical-align: text-bottom;
	 
}
#data_container
{
	height: 100%;
	width: 20%;
	margin-left: 1%;
	margin-right: 1%;
	display: flex;
	flex-direction: column;
}
#data_status
{
	height:60%;
	width:8%;
	margin:7%;
	background-color: #691F6E;
	display: flex;
	flex-direction: column;
	border-radius:20px;
}
#load_status
{
	background-image: url("/Images/KG.png");
	background-repeat: no-repeat;
	 background-size:     170px; 
	background-position: left center; 
}
#cap_status
{
	background-image: url("/Images/dust.png");
	background-repeat: no-repeat;
	 background-size: 150px; 
	background-position: left center; 
}
.status
{
	width: 80%;
	height: 40%;
	margin:5% 10%;
	background-color:#185adc;
	border-radius:20px;
	display: flex;
 	justify-content: center;
  	align-items: center;
	color: white;
	font-size: 60px;
   

}
.datas
{
	width:86%;
	margin:2.5% 7%;
	height:10%;
   background: url(water.png);
    background-repeat: repeat-x;
    animation: datas 10s linear infinite;
      
    box-shadow: 0 0 0 6px #98d7eb, 0  20px 35px rgba(0,0,0,1);

}
#map_container
{
	height: 100%;
	width: 100%;
	display: flex;
	flex-direction: column;	
}
#live_location_heading
{
	margin-top:10%;
	text-align: center;
  color:  GREY;
}
#map
{
	height: 70%;
	width: 90%;
	margin-left: 4%;
	margin-right:4%;
	border: 10px solid white;
	border-radius: 25px;
}
#alert_msg
{
	width:92%;
	height:20%;
	margin:4%;
	background-color:grey;
	border-radius: 20px;
	display: flex;
 	justify-content: center;
  	align-items: center;
	color: #41af7f;
	font-size: 25px;
	font-weight: bold;
}
.lat
{
	margin: 0px;
	font-size:0px;
}




@keyframes datas{
    0%
    {
        background-position: -500px 100px;
    }
    40%
    {
        background-position: 1000px -10px;
    }
  
    80% {
        background-position: 2000px 40px;
    }
    100% {
        background-position: 2700px 95px;
    }
  
}
