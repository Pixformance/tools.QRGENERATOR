#!/bin/bash

cd `dirname $0`/Tags/TagGenerator/bin/Release
fname=../../../../QRGenerator.7z

rm -f $fname
7z a $fname $sevenZopts
