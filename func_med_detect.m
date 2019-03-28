% Функция func_med_detect предназначена для автоматического нахождения объектов
% на изображении, а также выделение среди этих объетов, таких объетов, кототорые входят
% заданный диапазон яркости.
%
% Входные параметры :
% path          | путь к файлу исходного изображения;
% filename      | имя файла исход. изображения;
% threshold     | массив из двух элементов [a b], 
%               | где а - начальное, b - конечное значение диапазона яркости выделенных объектов
%               | a и b могут принимать значения в диапазаоне [0 1];  
%
%                Коэффциет усиления для управления порогом чувствительности при определении 
%                границ объектов функцией BW = edge(I,'Sobel',threshold * fudgeFactor):
% fudgeFactor1  |  для найденых объектов
% fudgeFactor2  |  для выделенных объектов

% Выходные параметры функции:
% result        | массив 2x2, где
%               | столбец 1 - параметры для всех найденных объектов
%               | столбец 2 - параметры для только выделенных объектов
%               |   срока 1 - количество
%               |   срока 2 - суммарная (общая площадь)
% Ic_final      | выходное изображение с результатами выделения и
%               | нумерацией выделенных объектов
%                 Выходное изображение Ic_final также автоматически
%                 сохраняется на диск в файл Ic_out.png

% Значения входных параметров для группы изображений в папке
% threshold = [0 .25];
% fudgeFactor1 = 0.8;
% fudgeFactor2 = 0.8;

function[result, Ic_final] = func_med_detect(path, filename, threshold, fudgeFactor1, fudgeFactor2)
%==========================================================================
%% 01
%==========================================================================
% Read and Convert the images to double
Ic01a = imread([path filename], 1);
Ic01a = im2double(Ic01a);
% Adjust contrast
Ic01b = imadjust(Ic01a, stretchlim(Ic01a), []);
% rgb2gray
Ig01a = rgb2gray(Ic01a);
Ig01b = rgb2gray(Ic01b);
% threshold = [0 .5];
Ig01c = imadjust(Ig01a, threshold, []);
%==========================================================================
%% 02
%==========================================================================
I1b = Ig01b;
I2c = Ig01c;

[~, threshold1] = edge(I1b, 'Sobel');
[~, threshold2] = edge(I2c, 'Sobel');
BWs_b = edge(I1b,'Sobel', threshold1 * fudgeFactor1);
BWs_c = edge(I2c,'Sobel', threshold2 * fudgeFactor2);

% Dilate the Image
se90=strel('line', 2, 90); 
se0 =strel('line', 2, 0);

BWsdil_b = imdilate(BWs_b, [se90 se0]); % imdilate - Dilate image
BWsdil_c = imdilate(BWs_c, [se90 se0]);

% Fill Interior Gaps

BWdfill_b = imfill(BWsdil_b, 4, 'holes'); % imfill - Fill image regions and holes
BWdfill_c = imfill(BWsdil_c, 4, 'holes');

% Smoothen the Object
seD = strel('diamond', 1);
BWfinal_b = imerode(imerode(BWdfill_b, seD), seD); % imerode - Erode image
BWfinal_c = imerode(imerode(BWdfill_c, seD), seD); 

% Crop detected object
seD = strel('diamond', 2);
BWfinal_b = imopen(BWfinal_b, seD); 
BWfinal_c = imopen(BWfinal_c, seD);
%==========================================================================
%% 03
%==========================================================================
L_b = bwlabel(BWfinal_b, 4); % bwlabel - Label connected components in 2-D binary image
num_b = max(max(L_b));

L_c = bwlabel(BWfinal_c, 4);
num_c = max(max(L_c));

[Bb, Lb] = bwboundaries(BWfinal_b);
stats_b = regionprops(Lb, 'Area');

[Bc, Lc] = bwboundaries(BWfinal_c);
stats_c = regionprops(Lc, 'Centroid', 'EquivDiameter', 'Area');

fi01 = figure('visible','off');
imshow(Ic01a);
hold on;
for k = 1:length(Bb)
    boundery = Bb{k};
    plot(boundery(:, 2), boundery(:, 1), 'b');
end
hold on;
for k = 1:length(Bc)
   boundery = Bc{k};
   plot(boundery(:, 2), boundery(:, 1),'r');
   text(boundery(1, 2) - 15, boundery(1, 1) + 15, num2str(k),...
       'Color', 'r', 'FontSize', 12, 'FontWeight', 'bold');
end

stats_b2 = struct2cell(stats_b);
stats_b2 = cell2mat(stats_b2(1, :));
area_b = sum(stats_b2);

stats_c2 = struct2cell(stats_c);
stats_c2 = cell2mat(stats_c2(1, :));
area_c = sum(stats_c2);

result = [num_b num_c; area_b area_c];
      
[Ic_final] = frame2im(getframe(fi01));

imwrite(Ic_final, 'Ic_out.png');
      
end