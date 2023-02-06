<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInitc8ef059bb0a6070d7d3f4529192a4893
{
    public static $prefixLengthsPsr4 = array (
        'E' => 
        array (
            'EasyRdf\\' => 8,
        ),
    );

    public static $prefixDirsPsr4 = array (
        'EasyRdf\\' => 
        array (
            0 => __DIR__ . '/..' . '/easyrdf/easyrdf/lib',
        ),
    );

    public static $classMap = array (
        'Composer\\InstalledVersions' => __DIR__ . '/..' . '/composer/InstalledVersions.php',
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->prefixLengthsPsr4 = ComposerStaticInitc8ef059bb0a6070d7d3f4529192a4893::$prefixLengthsPsr4;
            $loader->prefixDirsPsr4 = ComposerStaticInitc8ef059bb0a6070d7d3f4529192a4893::$prefixDirsPsr4;
            $loader->classMap = ComposerStaticInitc8ef059bb0a6070d7d3f4529192a4893::$classMap;

        }, null, ClassLoader::class);
    }
}
