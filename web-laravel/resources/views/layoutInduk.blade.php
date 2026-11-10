<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sistem SPP Siswa - Tailwind</title>
    <script src="https://cdn.tailwindcss.com"></script>
</head>
<body class="bg-slate-50 text-slate-800 antialiased font-sans">
    <!-- Navigasi Utama -->
    <nav class="bg-white border-b border-slate-200">
        <div class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
            <div class="flex justify-between h-16">
                <div class="flex">
                    <a href="#" class="flex items-center text-blue-600 font-bold text-lg tracking-wide">
                        SPP KEUANGAN RPL
                    </a>
                    <div class="hidden sm:ml-8 sm:flex sm:space-x-8">
                        <a href="#" class="inline-flex items-center px-1 pt-1 border-b-2 border-blue-500 text-sm font-semibold text-slate-900">Dashboard</a>
                        <a href="#" class="inline-flex items-center px-1 pt-1 border-b-2 border-transparent text-sm font-medium text-slate-500 hover:text-slate-700">+ Tambah Petugas</a>
                    </div>
                </div>
                <div class="flex items-center space-x-4">
                    <span class="text-sm text-slate-600">
                        Nama Pengguna
                        <span class="ml-2 inline-flex items-center px-2.5 py-0.5 rounded-full text-xs font-bold bg-red-100 text-red-800 uppercase">
                            ADMIN
                        </span>
                    </span>
                    <form action="#" method="POST" class="inline">
                        <button type="submit" class="px-3 py-1.5 text-xs font-semibold rounded-md border border-slate-300 text-slate-700 hover:bg-slate-100">
                            Keluar
                        </button>
                    </form>
                </div>
            </div>
        </div>
    </nav>

    <main class="max-w-6xl mx-auto px-4 sm:px-6 lg:px-8 py-8">
        <!-- Area Notifikasi / Alert Sistem -->
        <div class="mb-6 p-4 rounded-lg bg-green-50 border border-green-200 text-green-800 text-sm font-medium">
            Pesan notifikasi sukses sistem.
        </div>

        <!-- Area Konten Halaman -->
    </main>
</body>
</html>
