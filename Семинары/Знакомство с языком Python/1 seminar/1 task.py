"""
            Задача №1. Решение в группах
    За день машина проезжает n километров. Сколько
    дней нужно, чтобы проехать маршрут длиной m
    километров? При решении этой задачи нельзя
    пользоваться условной инструкцией if и циклами
"""
import math

n = int(input("Введите количество километров, которое проезжает машина в день: "))
m = int(input("Введите количество километров, которое нужно проехать машине: "))

print(f"За {math.ceil(m/n)}")
