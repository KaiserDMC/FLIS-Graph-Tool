**CURRENT VERSION - Graph Tool v1.8.0 - 2022-05-13 (BAM)**

*PREVIOUS VERSIONS:*  
1/ Graph Tool v1.23 - Demo  
2/ Graph Tool v1.3 - Full DB (FLIS 3.0.0.1)  
3/ Graph Tool v1.4 - Full DB (FLIS 3.0.0.2 and above)  
4/ Graph Tool v1.5 - Full DB (FLIS 3.0.0.1) + Norway  
5/ Graph Tool v1.5 - 2020-02-27  
6/ Graph Tool v1.5 - 2020-03-02  
7/ Graph Tool v1.5 - 2020-03-03  
8/ Graph Tool v1.51 - 2020-03-18  
9/ Graph Tool v1.52 - 2020-03-24  
10/ Graph Tool v1.53 - 2020-03-30  
11/ Graph Tool v1.54 - 2020-04-02  
12/ Graph Tool v1.55 - 2020-04-23  
13/ Graph Tool v1.56 - 2020-05-11  
14/ Graph Tool v1.57 - 2020-05-22  
15/ Graph Tool v1.58 - 2020-06-09  
16/ Graph Tool v1.60 - 2020-07-13 (BAM)  
17/ Graph Tool v1.61 - 2020-09-22 (BAM)  
18/ Graph Tool v1.62 - 2020-09-30 (BAM)  
19/ Graph Tool v1.62 - 2021-01-18 (BAM)  
20/ Graph Tool v1.63 - 2021-03-11 (BAM)  
21/ Graph Tool v1.63.1 - 2021-03-19 (BAM)  
22/ Graph Tool v1.63.2 - 2021-04-26 (BAM)  
23/ Graph Tool v1.63.3 - 2021-06-07 (BAM)  
24/ Graph Tool v1.63.4 - 2021-06-08 (BAM)  
25/ Graph Tool v1.63.5 - 2021-06-09 (BAM)  
26/ Graph Tool v1.7.0 - 2021-06-23 (BAM)  
27/ Graph Tool v1.7.1 - 2021-07-08 (BAM)  
28/ Graph Tool v1.7.2 - 2021-07-20 (BAM)  
29/ Graph Tool v1.7.3 - 2021-07-21 (BAM)  
30/ Graph Tool v1.7.4 - 2021-10-25 (BAM)  
31/ Graph Tool v1.7.5 - 2021-12-14 (BAM)  
32/ Graph Tool v1.7.6 - 2022-01-20 (BAM)  
33/ Graph Tool v1.7.7 - 2022-04-06 (BAM)  
34/ Graph Tool v1.7.8 - 2022-05-10 (BAM)  

***CHANGELOG:***  
1/ Version 1.23 was presented as a short DEMO. Only few facilieties were
available. Idea was to check if everything was operational. After some
minor tweeks the Graph Tool was approved for usage, provided the FI 
proceeds to using it with caution. - 2019-04-06  
2/ Version 1.3 implemented full DB with all ILS facilities serviced by
LFV. The tool was to be used with FLIS versions up until 3.0.0.1. - 2019-11-20  
3/ Version 1.4 implemented full DB with all ILS facilities serviced by
LFV. The tool was to be used with FLIS versions after 3.0.0.1. 
The change was needed as in version 3.0.0.2 additional parameters such
as DME AGC and DME Error were introduced to the 'GP CLEARANCE' routine.
The required shift of data and formulas with 3 columns and some graph 
adjustments. - 2019-11-20  
4/ Version 1.5 incorporated multiple changes:  
- Additional labels to some graphs to make the easier to understand
- Some graphs were rescaled with tighter spacings
- A field showing flight direction (CW or CCW) for the PO graphs added
- Formula for missing data was adjusted (wrop time error) as although
data was not missing it was shown as such due to 0.1 seconds check. 
This check is now changed to 0.15 seconds
- The Graph Tool no longer requires 2 versions. A macro and logical
function was implemented inside the tool tha will import the data in the
correct format for the 'GP SLICE/LEVEL RUNS' based on the software version
selected by the FI inside the 'FormFill' section. Thus versions until 
3.0.0.1 will use the old format, while all others will use the new one.
- The nominal GP angle is no longer hard coded to 3 degrees. It was 
found that the graphs were not scaling along with the angle as all 
calcualtions were made for 3 degrees. This will now change based on 
nominal angle show in the facilities' database. - 2020-02-27  
5/ Version 1.5 2020-03-02 edition - fixed a small bug with graph export.
During one of the reports it was noticed that the tool will printout all
graphs and not only the ones that are selected. This issue is now fixed,
with macro and formula update.  
6/ Version 1.5 2020-03-03 edition - fixed a but related to the nominal
angle marks/events that come from AgGFIS for all Slice runs. Calculation
is now performed manually based on distance and height of flight,
instead of trusting the FLIS RAW data. A missing line of code was found
for the +/- 8 deg runs, it is now implemented again. No further issues
should be present...  
7/ Version 1.51 2020-03-18 edition - Updated the names of ILS and PAPI 
procedures in Database sheet, for easier future improvements. 
This update does not affect the current state of calculations. The scale
on LOC SDM graph during PO runs was also updated.  
8/ Version 1.52 2020-03-24 edition - fixed a previous error regarding
the calculation of Theta on Slice graphs, in regards to Level Run sheets
which are valid for FLIS 3.0.0.4 or above...   
Added DME AGC graphs to Level Runs, PO and LOC/GP Center line.. 
The level runs work ONLY for FLIS 3.0.0.4 or above, as previous versions
do not store DME data for Slices...  
9/ Version 1.53 2020-03-30 edition - minor changes to graph headers..
Some hcanges were bigger FI field, removal of grpah number, RWY number..  
10/ Version 1.54 2020-04-02 edition - change on DME sgn lvl label...
Reversed + and - on PO graphs, as they were wrong...  
11/ Version 1.55 2020-04-23 edition - fixed issue with diagram no. 
label.. added additional Tolerance line inside the LEGEND field of 
all Slice runs for better visualisation...  
12/ Version 1.56 2020-05-11 edition - fixed minor issues with naming of
inspection types and added DME tx on Header for various graphs  
13/ Version 1.57 2020-05-22 edition - Added field to select DME Tx 
during LOC runs on Formfill windown; Changed Rollout scalling to +-40uA;
Added Tx selection for GP Slice with AZ; Added search track graph for
LOC approach runs; Fixed headers on GP Slice with AZ...  
14/ Version 1.58 - 2020-06-09 - includes minor changes on graph spacing
and additional fields to facilitate for DME TX changes....  
15/ Version 1.59 - 2020-06-11 - includes new colour scheme...  
16/ Version 1.60 - 2020-07-13 - swapped LFV with BAM logo on all graphs.  
17/ Version 1.61 - 2020-09-22 - new graph margins on LOC/GP structure...  
18/ Version 1.62 - 2020-09-30 - implements changes suggested by TN...
LOC is now above GP graph on the DME signal level page...  
The DME signal level page is now Signal Graph and includes LOC AGC, SDM
and GP AGC, SDM in addition to the existing DME SGN level during Appr...  
19/ Added new options for FLIS software version...  
20/ Added PO 17NM and PO 25NM... Added dottd line where 0uA are to be
for LOC Approach...  
21/ LOC Approach and GP Approach now show data up to 8NM, previously
only to 4NM... Version numbering changed to facilitate small updates...  
22/ LOC X-Over Tolerances for LOC AGC and DME AGC added to graphs...  
23/ Graph visualization tweaks...  
24/ GP Slice distance changed to 15NM...  
25/ GP Slice, DME tolerance added...  
26/ Version 1.7.0 - introduces a lot of cosmetical changes for almost
all graphs... Some changes are extra tolerance lines for AGC levels,
change of Rollout layout, position of graphs inside the pdf file,
labeling and etc...  
27/ Version 1.7.1 - grap tweaks, estethics and namings...  
28/ Version 1.7.2 - removed DME Search/Track graphs, as they do not give
any valuable information and are quite often from, due to the M-file
structure... Minor header changes...  
29/ Version 1.7.3 - Flyability graph labels...  
30/ Version 1.7.4 - LOC signal and DME signal colour change for Part Orbit  
31/ Version 1.7.5 - Graph adjustments - uniformity and improved adaption 
to input data...  
32/ Version 1.7.6 - cosmetic graph changes...  
33/ Version 1.7.7 - added Legend to FormFill.. better accuracy on GP-Slice
distance in NM...  
34/ Version 1.7.8 - Minor cosmetic changes to FormFill to indicate 
mandatory fields... Added "Distance in NM" to all X-axis required...  
35/ Version 1.8.0 - Minor FormFill tweeks... Added DME AGC for Slice ±8°.
According to the version of FLIS selected the tool will switch between
Slice ±8° Tx. and Level Run ±8° Tx. ... This follows the same logic and
fuctionality as for normal Slice and Level Run...  
