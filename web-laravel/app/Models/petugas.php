<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Foundation\Auth\User as Authenticatable;
use Illuminate\Notifications\Notifiable;

class petugas extends Model
{
    use Notifiable;

    // Menentukan nama tabel kustom
    protected $table = 'petugas';

    // Menentukan nama primary key kustom
    protected $primaryKey = 'id_petugas';

    // Kolom yang dapat diisi mass-assignment
    protected $fillable = [
        'username',
        'password',
        'nama_petugas',
        'level',
    ];

    // Menyembunyikan kolom password saat konversi array/JSON
    protected $hidden = [
        'password',
    ];
}
