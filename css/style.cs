

.sel_heading {
  list-style-type: none;
  font-family: Arial, Helvetica, sans-serif;
  font-size: 15px;
  font-size-adjust: none; 
  font-weight: bold;  
}

.colormapname {
  display:table;
  list-style-type: none;
  font-family: Arial, Helvetica, sans-serif;
  font-size: 15px;
  font-size-adjust: none; 
  font-weight: normal;  
  padding-left:5px;
}

.transformname {
  display:table;
  list-style-type: none;
  font-family: Arial, Helvetica, sans-serif;
  font-size: 15px;
  font-size-adjust: none; 
  font-weight: normal;  
  padding-left:5px;
}


.timerangename,.varname,.sel_input {
 display:table;
  list-style-type: none;
  font-family: Arial, Helvetica, sans-serif;
  font-size: 15px;
  font-size-adjust: none; 
  font-weight: normal;  
  padding-left:5px;
}

.xaxis line,
.xaxis path,
.yaxis line,
.yaxis path
{
	fill:none;
	stroke: black;
	shape-rendering: crispEdges;
}


.grid line {
	fill:none;
	stroke: #ccc;
	shape-rendering: crispEdges;	
}

.gridx  {
stroke-width:1;
fill none;
}

.yaxis text,
.xaxis text
{
	font-family:sans-serif;
	font-size: 11px;
}

.label {
	font-family:sans-serif;
	font-weight:bold;
	font-size: 13px;	
}

.regio {
  stroke: #4a4a4a;
  stroke-width:0.5;
  fill: #ffffff;
}

.outline {
  stroke: #0a0a0a;
  stroke-width:2.0;
  fill: #0f0fff;
  fill-opacity: 0.0;

}

.border {
  stroke:#222222;
  stroke-width:5.0;
}

.hover_selectie {
 background-color: LightBlue;
}
.active_selectie {
 background-color: SteelBlue;
}




/* Header styles */
#header {
  clear:both;
  float:left;
  width:100%;
}
#header {
  border-bottom:1px solid #000;
}
#header p,
#header h1,
#header h2 {
  padding:.4em 15px 0 15px;
  margin:0;
}
#header ul {
  clear:left;
  float:left;
  width:100%;
  list-style:none;
  margin:10px 0 0 0;
  padding:0;
}
#header ul li {
  display:inline;
  list-style:none;
  margin:0;
  padding:0;
}
#header ul li a {
  display:block;
  float:left;
  margin:0 0 0 1px;
  padding:3px 10px;
  text-align:center;
  background:#eee;
  color:#000;
  text-decoration:none;
  position:relative;
  left:15px;
  line-height:1.3em;
}
#header ul li a:hover {
  background:#369;
  color:#fff;
}
#header ul li a.active,
#header ul li a.active:hover {
  color:#fff;
  background:#000;
  font-weight:bold;
}
#header ul li a span {
  display:block;
}



.colmask {
  position:relative;  /* This fixes the IE7 overflow hidden bug */
  clear:both;
  float:left;
  width:100%;     /* width of whole page */
  overflow:hidden;    /* This chops off any overhanging divs */
}
/* common column settings */
.colright,
.colmid,
.colleft {
  float:left;
  width:100%;     /* width of page */
  position:relative;
}
.col1,
.col2,
.col3 {
  float:left;
  position:relative;
  padding:0 0 1em 0;  /* no left and right padding on columns, we just make them narrower instead 
          only padding top and bottom is included here, make it whatever value you need */
  overflow:hidden;
}
/* 3 Column settings */
.threecol {
  background:#eee;    /* right column background colour */
}
.threecol .colmid {
  right:15%;      /* width of the right column */
  background:#fff;    /* center column background colour */
}
.threecol .colleft {
  right:78%;      /* width of the middle column */
  background:#f4f4f4; /* left column background colour */
}
.threecol .col1 {
  width:75%;      /* width of center column content (column width minus padding on either side) */
  left:100%;      /* 100% plus left padding of center column */
}
.threecol .col2 {
  width:8%;      /* Width of left column content (column width minus padding on either side) */
  left:16%;     /* width of (right column) plus (center column left and right padding) plus (left column left padding) */
}
.threecol .col3 {
  width:12%;      /* Width of right column content (column width minus padding on either side) */
  left:95%;     /* Please make note of the brackets here:
          (100% - left column width) plus (center column left and right padding) plus (left column left and right padding) plus (right column left padding) */
}


#varlist {
  list-style: none;
  
}

#rightbox ul {
  list-style: none;
  padding:0;
  margin:0;
}


#rightbox li {
  display: inline;  
  margin: 0 0.5em 0 0;  
  color:#000;
}

#rightbox a {
 text-decoration:none; 
  color:#000;
}


.dayl {
stroke: blue; 
stroke-linecap: round; 
fill: none; 
stroke-width: 2;
}

/* center moviecontrols */
#moviecontrols{
width: 50%;
margin:0 auto;
}

#chart_svg{
display: block; 
margin: 0 auto;
}

#ts1,#ts2, #ts3{
display:inline;
}


.selectie_header, .selectie_mheader {
height:20px;
}
.active {
background-color: SteelBlue;
}



#tab_chart{
text-align: left;
font-family:sans-serif;
font-weight:bold;
font-size: 13px;  
background:#d2ecf7;
}


#tab_data{
text-align: right;  
font-family:sans-serif;
font-weight:bold;
font-size: 13px;  
background:#d2ecf7;
}


#tabledata * th,td {
font-family:sans-serif;
text-align:right;
}

.even {
background-color: #d2ecf7;
}

.odd {
background-color: #9cd7ef;
}

