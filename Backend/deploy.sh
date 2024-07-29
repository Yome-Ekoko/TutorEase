#!/bin/sh
GIT_VERSION=$(git describe --tags)
docker build -t registry.aff.ng/TutorEase_core:$GIT_VERSION -f TutorEase/Dockerfile .
docker build -t registry.aff.ng/TutorEase_admin:$GIT_VERSION -f TutorEase/Dockerfile .
docker push registry.aff.ng/TutorEase_core:$GIT_VERSION
docker push registry.aff.ng/TutorEase_admin:$GIT_VERSION

