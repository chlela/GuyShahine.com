/// <binding BeforeBuild='build' Clean='clean' ProjectOpened='watch' />
var gulp = require('gulp'),
    gutil = require('gulp-util'),
    del = require('del'),
    jshint = require('gulp-jshint'),
    less = require('gulp-less'),
    batch = require('gulp-batch'),
    csso = require('gulp-csso');
csslint = require('gulp-csslint'),
csslintVisualStudioReporter = require('gulp-visual-studio-csslint'),
watch = require('gulp-watch');

var paths = {
  src: {
    less: './content/less/**/*.less',
    //sass: './src/stylesheets/sass/**/*.scss',
    css: './build/assets/stylesheets/*.css',
    scripts: './scripts/**/*.js',
    images: './content/images/**/*',
    //html: './*.html'
    tests: './tests/**/*.js',
  },
  dist: {
    css: './build/assets/stylesheets',
    cssmin: './build/assets/stylesheets/min',
    scripts: './build/assets/javascripts',
    images: './build/assets/images',
    html: './build'
  }
};

gulp.task('jshint', function () {
  return gulp.src([paths.src.scripts, '!scripts/external/**'])
  .pipe(jshint())
  .pipe(jshint.reporter('jshint-stylish'));
});

// Clean Build Folder
gulp.task('clean', function () {
  return del([paths.dist.html]);
});

gulp.task('less', function () {
  return gulp.src(['./content/less/site.less'])
    .pipe(less())
    .pipe(gulp.dest(paths.dist.css));
});

// CSS Lint
gulp.task('csslint', function () {
  return gulp.src([paths.src.css, '!/bootstrap.css*'])
  .pipe(csslint())
  .pipe(csslint.reporter(csslintVisualStudioReporter));
});

gulp.task('cssmin', function () {
  return gulp.src([paths.dist.css + '/bootstrap.css'])
      .pipe(csso())
      .pipe(gulp.dest(paths.dist.cssmin));
});

gulp.task('watch', function () {
  watch(paths.src.less, batch(function (events, done) {
    gulp.start('build', done);
  }));
});

// Build tasks
gulp.task('build', ['jshint', 'less', 'cssmin'])

// Production tasks
//gulp.task('prod', ['clean','jshint']);

// Default Task
gulp.task('default', ['build', 'watch'], function () {
  // place code for your default task here
});
