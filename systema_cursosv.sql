-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-07-2022 a las 19:40:43
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `systema_cursosv`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos`
--

CREATE TABLE `cursos` (
  `id_curso` int(11) NOT NULL,
  `nombre_curso` text COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion` text COLLATE utf8mb4_spanish_ci NOT NULL,
  `objetivo` text COLLATE utf8mb4_spanish_ci NOT NULL,
  `id_login_instructor` int(11) NOT NULL,
  `hr_inicio` int(30) NOT NULL,
  `hr_fin` int(30) NOT NULL,
  `duracion_curso` text COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `curso_estudiante`
--

CREATE TABLE `curso_estudiante` (
  `id_login_estudiante` int(11) NOT NULL,
  `id_curso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `id_registro` int(11) NOT NULL,
  `correo_user` varchar(40) COLLATE utf8mb4_spanish_ci NOT NULL,
  `contraseña _user` varchar(8) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login_instructor`
--

CREATE TABLE `login_instructor` (
  `id_login_instructor` int(11) NOT NULL,
  `correo_instructor` varchar(40) COLLATE utf8mb4_spanish_ci NOT NULL,
  `nombre_instructor` text COLLATE utf8mb4_spanish_ci NOT NULL,
  `contraseña_instructor` varchar(8) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login_studen`
--

CREATE TABLE `login_studen` (
  `id_login_estuden` int(11) NOT NULL,
  `correo_estudiante` varchar(40) COLLATE utf8mb4_spanish_ci NOT NULL,
  `nombre_estudiante` text COLLATE utf8mb4_spanish_ci NOT NULL,
  `Contraseña_estudiante` varchar(8) COLLATE utf8mb4_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`id_curso`),
  ADD UNIQUE KEY `id_instructor` (`id_login_instructor`);

--
-- Indices de la tabla `curso_estudiante`
--
ALTER TABLE `curso_estudiante`
  ADD UNIQUE KEY `id_estudiante` (`id_login_estudiante`),
  ADD UNIQUE KEY `id_cursos` (`id_curso`),
  ADD UNIQUE KEY `id_cursos_2` (`id_curso`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id_registro`);

--
-- Indices de la tabla `login_instructor`
--
ALTER TABLE `login_instructor`
  ADD PRIMARY KEY (`id_login_instructor`);

--
-- Indices de la tabla `login_studen`
--
ALTER TABLE `login_studen`
  ADD PRIMARY KEY (`id_login_estuden`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `login`
--
ALTER TABLE `login`
  MODIFY `id_registro` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `login_instructor`
--
ALTER TABLE `login_instructor`
  MODIFY `id_login_instructor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `login_studen`
--
ALTER TABLE `login_studen`
  MODIFY `id_login_estuden` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cursos`
--
ALTER TABLE `cursos`
  ADD CONSTRAINT `cursos_ibfk_1` FOREIGN KEY (`id_login_instructor`) REFERENCES `login_instructor` (`id_login_instructor`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `curso_estudiante`
--
ALTER TABLE `curso_estudiante`
  ADD CONSTRAINT `curso_estudiante_ibfk_1` FOREIGN KEY (`id_login_estudiante`) REFERENCES `login_studen` (`id_login_estuden`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `curso_estudiante_ibfk_2` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
