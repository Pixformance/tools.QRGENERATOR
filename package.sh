#!/bin/bash

fname=`dirname $0`/QRGenerator.7z
cd `dirname $0`/Tags/TagGenerator/bin/Release

echo Creating $fname...
7z a $fname $sevenZopts
