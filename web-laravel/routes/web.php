<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('formLogin');
});

Route::post('formLogin',[AuthController::class, 'login']);
Route::get('formTambahPetugas',[AuthController::class, 'tampil']);