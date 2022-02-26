/// <binding AfterBuild='default' Clean='clean' />

const gulp = require('gulp');
const del = require('del');
const uglify = require('gulp-uglify');

var paths = {
    scripts: [
        'Client/**/*.js',
        'Client/**/*.ts',
        'Client/**/*.map'
        //'!Client/**/*.d.ts'
    ],
    lib: []
};

// 执行清理任务.
gulp.task('clean', function () {
    return del(['wwwroot/js/**/*', 'Client/**/*.js', 'Client/**/*.map']);
});

// 仅清除编译的 js
gulp.task('clean:src', function () {
    return del(['Scripts/**/*.js', 'Scripts/**/*.map']);
});

gulp.task('default', function (done) {
    gulp.src(paths.scripts)
        .pipe(gulp.dest('wwwroot/js'));
        //.pipe(uglify())
        //.pipe(gulp.dest('wwwroot/js'));
    done();
});