<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Petugas - SPP</title>
    <script src="https://cdn.tailwindcss.com"></script>
</head>
<body class="bg-slate-100 min-h-screen flex items-center justify-center p-4">
    <div class="w-full max-w-md bg-white rounded-2xl shadow-sm border border-slate-200 p-8">
        <div class="text-center mb-6">
            <h1 class="text-2xl font-bold text-slate-900 tracking-tight">Login Portal SPP</h1>
            <p class="text-sm text-slate-500 mt-1">Masukkan akun petugas untuk memulai layanan</p>
        </div>

        <form action="#" method="POST" class="space-y-4">
            <div>
                <label for="username" class="block text-sm font-medium text-slate-700 mb-1">Username</label>
                <input type="text" name="username" id="username" 
                       class="w-full px-3.5 py-2.5 rounded-lg border border-slate-300 focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-sm"
                       placeholder="Masukkan username" required autofocus>
                <!-- Tampilan Pesan Validasi Error -->
                <p class="text-xs text-red-600 mt-1">Kredensial username atau kata sandi tidak cocok.</p>
            </div>

            <div>
                <label for="password" class="block text-sm font-medium text-slate-700 mb-1">Kata Sandi</label>
                <input type="password" name="password" id="password" 
                       class="w-full px-3.5 py-2.5 rounded-lg border border-slate-300 focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-blue-500 text-sm"
                       placeholder="Masukkan kata sandi" required>
            </div>

            <div class="flex items-center">
                <input type="checkbox" name="remember" id="remember" class="h-4 w-4 rounded border-slate-300 text-blue-600 focus:ring-blue-500">
                <label for="remember" class="ml-2 block text-xs text-slate-600">Ingat sesi login saya</label>
            </div>

            <button type="submit" 
                    class="w-full py-2.5 px-4 rounded-lg bg-blue-600 hover:bg-blue-700 text-white font-semibold text-sm shadow-sm transition">
                Masuk ke Sistem
            </button>
        </form>
    </div>
</body>
</html>
