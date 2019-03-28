clc; close all; clear;
path = 'D:\Projects\MED\Matlab\SourceCode\';
filename = 'Lc_input.tif';
threshold = [0 .25];
fudgeFactor1 = 0.9;
fudgeFactor2 = 0.9;

[result, Ic_final] = func_med_detect(path, filename, threshold, fudgeFactor1, fudgeFactor2);
figure;
imshow(Ic_final);