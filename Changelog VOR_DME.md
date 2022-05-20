**CURRENT VERSION - Graph Tool VOR_DME/E-DME v1.4.8 - 2022-05-10 (BAM)**  

*PREVIOUS VERSIONS:*  
1/ Graph Tool VOR_DME/E-DME v1.1 - 2020-07-13 (BAM)  
2/ Graph Tool VOR_DME/E-DME v1.2 - 2021-01-18 (BAM)  
3/ Graph Tool VOR_DME/E-DME v1.3.0 - 2021-03-29 (BAM)  
4/ Graph Tool VOR_DME/E-DME v1.3.1 - 2021-04-08 (BAM)  
5/ Graph Tool VOR_DME/E-DME v1.3.2 - 2021-06-07 (BAM)  
6/ Graph Tool VOR_DME/E-DME v1.4.0 - 2021-06-22 (BAM)  
7/ Graph Tool VOR_DME/E-DME v1.4.1 - 2021-07-08 (BAM)  
8/ Graph Tool VOR_DME/E-DME v1.4.2 - 2021-07-09 (BAM)  
9/ Graph Tool VOR_DME/E-DME v1.4.3 - 2021-07-20 (BAM)  
10/ Graph Tool VOR_DME/E-DME v1.4.4 - 2021-12-09 (BAM)  
11/ Graph Tool VOR_DME/E-DME v1.4.5 - 2021-12-14 (BAM)  
12/ Graph Tool VOR_DME/E-DME v1.4.6 - 2022-02-17 (BAM)  
13/ Graph Tool VOR_DME/E-DME v1.4.7 - 2022-04-06 (BAM)  

***CHANGELOG:***  
1/ Version 1.1 - swapped LFV with BAM logo on all graphs for both E-DME
and VOR_DME graph tools.  
**OBS!** There were no changelogs for ver 1.0 as they were still in testing 
stage during LFV operations. Changelog is to be used from now on!!!  
2/ Version 1.2 - Orbits are now every 5 degrees instead of 10 as before  
3/ Version 1.2, edit 2021-01-18 - added new FLIS software versions  
4/ Version numbering changed to facilitate small updates...  
5/ Version update after error found in Orbit graph prints...  
6/ Version 1.3.1 - added "Label only" signs...  
7/ Version 1.3.2 - graph visualization tweaks...  
8/ Version 1.4.0 - VOR and DME orbit adjustments... Signal level now
shows the minimum value between each 5 degrees, instead of a singel
point value like before... Value between 355 and 360 degrees plots
on the 355 degree line...  
9/ Version 1.4.1 - Graph tweaks, estethics and namings...  
10/ Version 1.4.2 - small graph tweaks and unsaved changes...  
11/ Version 1.4.3 - removed DME Search/Track graphs, as they do not give
any valuable information and are quite often from, due to the M-file
structure... Minor header changes...  
12/ Version 1.4.4 - Graphics for VOR and DME were adjusted to not show
values lower than -100 dBm, if the value is lower the graph will set a 
manual value of -100 dBm.  
13/ Version 1.4.5 - Graph adjustments - uniformity and improved adaption 
to input data...  
14/ Version 1.4.6 - VOR orbit error correction is now automatically adjusted
for "+360 degrees" error. Previously this was done manually... Version bump
for E-DME graph tool.  
15/ Version 1.4.7 - added Legend to FormFill... VOR Align now presents to 360
degrees, instead of 350 degrees...  
16/ Version 1.4.8 - Changed distance to station calculation to use 
"distance_x_gnss" instead of "distance_xy_gnss" and "distance_xy_dme"...
Minor cosmetic changes to FormFill to indicate mandatory fields...  
