# Flight Inspection System (FLIS) Graph Tool
Converts FLIS' RAW datafiles (.txt/.csv) to better graphics.  
Some manual user input is needed in addition to the datafiles in order to execute all necessary calculations.

## All-in-one Design
All new WPF UI (.Net 8) is currently under construction.
Separate versions of the tool will no longer be necessary.
ETA: Q3-2024

## Legacy
Legacy versions of the tool are retained and will not be removed from this repo. However, they utilise MS Excel to fill the necessary information and import the data.
All graphics are generated automatically using VBA Macros. Export to PDF files is also handled by a Macro script.  

## Variants (Legacy only)
There are three variations of *Graph Tool* depending on which type of facility was inspected, i.e. what type of graphs can be generated: 
* ILS/LOC with or without DME
* C-VOR/D-VOR with or without DME
* E-DME
