<div class="max-w-xl mx-auto bg-white rounded-2xl border border-slate-200 shadow-sm overflow-hidden">
    <div class="bg-blue-600 px-6 py-4 text-white">
        <h2 class="text-lg font-bold">Pendaftaran Akun Petugas Baru</h2>
        <p class="text-xs text-blue-100">Buat akun untuk petugas loket atau administrator baru</p>
    </div>
    <div class="p-6">
        <form action="#" method="POST" class="space-y-4">
            <div>
                <label class="block text-xs font-semibold text-slate-700 mb-1">Username Akun *</label>
                <input type="text" name="username" placeholder="Masukkan username unik" required autofocus
                       class="w-full px-3.5 py-2 rounded-lg border border-slate-300 text-sm focus:outline-none focus:ring-2 focus:ring-blue-500">
                <!-- Tampilan Pesan Validasi Error -->
                <p class="text-xs text-red-600 mt-1">Username sudah digunakan.</p>
            </div>

            <div>
                <label class="block text-xs font-semibold text-slate-700 mb-1">Nama Lengkap Petugas *</label>
                <input type="text" name="nama_petugas" placeholder="Nama lengkap petugas" required
                       class="w-full px-3.5 py-2 rounded-lg border border-slate-300 text-sm focus:outline-none focus:ring-2 focus:ring-blue-500">
            </div>

            <div>
                <label class="block text-xs font-semibold text-slate-700 mb-1">Hak Akses / Level *</label>
                <select name="level" required class="w-full px-3.5 py-2 rounded-lg border border-slate-300 text-sm bg-white focus:outline-none focus:ring-2 focus:ring-blue-500">
                    <option value="petugas">Petugas Loket</option>
                    <option value="admin">Administrator</option>
                </select>
            </div>

            <div>
                <label class="block text-xs font-semibold text-slate-700 mb-1">Kata Sandi (Minimal 6 Karakter) *</label>
                <input type="password" name="password" placeholder="Kata sandi" required
                       class="w-full px-3.5 py-2 rounded-lg border border-slate-300 text-sm focus:outline-none focus:ring-2 focus:ring-blue-500">
            </div>

            <div>
                <label class="block text-xs font-semibold text-slate-700 mb-1">Konfirmasi Kata Sandi *</label>
                <input type="password" name="password_confirmation" placeholder="Ulangi kata sandi" required
                       class="w-full px-3.5 py-2 rounded-lg border border-slate-300 text-sm focus:outline-none focus:ring-2 focus:ring-blue-500">
            </div>

            <div class="pt-4 flex justify-between items-center border-t border-slate-200">
                <a href="#" class="px-4 py-2 border border-slate-300 hover:bg-slate-50 text-slate-700 text-sm font-medium rounded-lg">
                    Kembali
                </a>
                <button type="submit" class="px-5 py-2 bg-blue-600 hover:bg-blue-700 text-white text-sm font-semibold rounded-lg shadow-sm">
                    Simpan Petugas
                </button>
            </div>
        </form>
    </div>
</div>
