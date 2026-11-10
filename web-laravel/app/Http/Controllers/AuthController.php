<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\Auth;
use App\Models\petugas;
use Illuminate\Http\Request;

class AuthController extends Controller
{
    // Menampilkan halaman form login
    public function showLogin()
    {
        if (Auth::check()) {
            return redirect()->route('dashboard');
        }
        return view('auth.login');
    }

    // Memproses data login pengguna
    public function login(Request $request)
    {
        // Validasi input
        $request->validate([
            'username' => 'required',
            'password' => 'required',
        ]);

        // Menyusun kredensial
        $credentials = $request->only('username', 'password');

        // Eksekusi verifikasi masuk
        if (Auth::attempt($credentials)) {
            // Regenerasi session ID keamanan
            $request->session()->regenerate();

            return redirect()->route('dashboard')->with('success', 'Selamat datang kembali!');
        }

        // Jika gagal, kembali dengan membawa input username lama
        return back()->withErrors([
            'username' => 'Username atau kata sandi tidak cocok.',
        ])->withInput($request->only('username'));
    }

    // Memproses keluar dari sistem
    public function logout(Request $request)
    {
        Auth::logout();

        // Bersihkan dan batalkan session aktif
        $request->session()->invalidate();

        // Buat ulang token CSRF
        $request->session()->regenerateToken();

        return redirect()->route('login')->with('success', 'Anda telah berhasil keluar dari sistem.');
    }

}
